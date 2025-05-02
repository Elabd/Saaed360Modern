using Application.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Saaed360Modern.Application.Abstractions;
using Saaed360Modern.Contracts.Wcf;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure.Services
{
    public class RequestService : IRequestService
    {
        private readonly IAppDbContext _context;
        private readonly IReportWcfService _reportService;

        public RequestService(IAppDbContext context, IReportWcfService reportService)
        {
            _context = context;
            _reportService = reportService;
        }

        public async Task<IEnumerable<LookupDto>> GetSourceOfModificationAsync(CancellationToken cancellationToken = default)
        {
            return await _context.SourceOfModificationDims
                .Select(x => new LookupDto
                {
                    Id = x.Id,
                    Description = x.Name,
                    Code = x.Code
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<LookupDto>> GetRequestTypeListAsync(CancellationToken cancellationToken = default)
        {
            return await _context.ReportRequestTypeDims
                .Select(x => new LookupDto
                {
                    Id = x.ReportRequestTypeId,
                    Description = x.Description,
                    Code = x.Code
                })
                .ToListAsync(cancellationToken);
        }
       
        public async Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleIds)
        {
            try
            {
                var request = await _reportService.GetRequestByIdAsync(requestId, roleIds);
                if (request == null) return null;

                var linkedRequest = await _context.ReportRequests
                    .FirstOrDefaultAsync(x => x.RequestId == requestId);

                if (linkedRequest?.LinkedRequestId != null)
                {
                    var linkedRequestNumber = await _context.ReportRequests
                        .Where(x => x.RequestId == linkedRequest.LinkedRequestId)
                        .Select(x => x.RequestNumber)
                        .FirstOrDefaultAsync();

                    request.LinkedRequestNumber = linkedRequestNumber;
                    request.LinkedRequestId = linkedRequest.LinkedRequestId;
                }

                return request;
            }
            catch (Exception ex)
            {
                // Log exception
                return null;
            }
        }

        public async Task<ReportRequestDto> GetTransferredRequestByIdAsync(long requestId, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _reportService.GetTransferedRequestByIdAsync(requestId);
            }
            catch (Exception ex)
            {
                // Log exception
                return null;
            }
        }

        public async Task<bool> TransferRequestAsync(ReportRequestDto request, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _reportService.TransferRequestAsync(request);
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public async Task<bool> CanTransferRequestAsync(long requestId, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _reportService.CanTransferRequestAsync(requestId);
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        public async Task<bool> SaveRequestAsync(ReportRequestDto request, CancellationToken cancellationToken = default)
        {
            try
            {
                bool result = await _reportService.SaveRequestAsync(request);
                
                if (result && request.RequestId != 0 && request.RequestTypeCode == "ModifyReport" && 
                    request.FieldsToBeApproved?.Any(x => x.Approved == true) == true)
                {
                    var status = await _context.UploadedReportStatuses
                        .FirstOrDefaultAsync(x => x.ReportId == request.ReportId, cancellationToken);

                    if (status != null)
                    {
                        status.RetryCount = 0;
                        _context.UploadedReportStatuses.Update(status);
                        await _context.SaveChangesAsync(cancellationToken);
                    }
                }

                if (!string.IsNullOrEmpty(request.LinkedRequestNumber))
                {
                    await SaveLinkedRequestDataAsync(request.LinkedRequestNumber, request.ReportId);
                }

                return result;
            }
            catch (Exception ex)
            {
                // Log exception
                return false;
            }
        }

        private async Task SaveLinkedRequestDataAsync(string linkedRequestNumber, int? reportId)
        {
            var currentRequest = await _context.ReportRequests
                .Where(x => x.ReportId == reportId)
                .OrderByDescending(x => x.RequestId)
                .FirstOrDefaultAsync();

            if (currentRequest != null)
            {
                var linkedRequest = await _context.ReportRequests
                    .FirstOrDefaultAsync(x => x.RequestNumber == linkedRequestNumber);

                if (linkedRequest != null)
                {
                    // Update current request with linked request
                    currentRequest.LinkedRequestId = linkedRequest.RequestId;
                    _context.ReportRequests.Update(currentRequest);

                    // Add description as comment if exists
                    if (!string.IsNullOrEmpty(linkedRequest.Desc))
                    {
                        var comment = new ReportRequestComment
                        {
                            Comment = linkedRequest.Desc,
                            CreatedBy = linkedRequest.CreatedBy,
                            CreationDate = linkedRequest.CreationDate,
                            IsDeleted = false,
                            ReportRequestId = currentRequest.RequestId
                        };
                        await _context.ReportRequestComments.AddAsync(comment);
                    }

                    // Copy attachments
                    var linkedRequestAttachments = await _context.ReportRequestDocuments
                        .Where(x => x.RequestId == linkedRequest.RequestId)
                        .ToListAsync();

                    foreach (var attachment in linkedRequestAttachments)
                    {
                        var newAttachment = new ReportRequestDocument
                        {
                            BinaryBase64Object = attachment.BinaryBase64Object,
                            CreateDateTimeStamp = linkedRequest.CreationDate,
                            CreatedBy = linkedRequest.CreatedBy,
                            DocumentName = attachment.DocumentName,
                            IsDeleted = attachment.IsDeleted,
                            BinaryDescriptionText = attachment.BinaryDescriptionText,
                            BinaryHexObject = attachment.BinaryHexObject,
                            BinarySize = attachment.BinarySize,
                            DocumentTypeId = attachment.DocumentTypeId,
                            FileFormatId = attachment.FileFormatId,
                            RequestId = currentRequest.RequestId
                        };
                        await _context.ReportRequestDocuments.AddAsync(newAttachment);
                    }

                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task<IEnumerable<DifferentValues>> GetDifferentsAsync(ReportDTO modifiedReport, CancellationToken cancellationToken = default)
        {
            try
            {
                return await _reportService.GetModificationListAsync(modifiedReport);
            }
            catch (Exception ex)
            {
                // Log exception
                return null;
            }
        }

        public async Task<IEnumerable<RequestListDTO>> GetRequestListAsync(
            ReportRequestSearchCriteriaDTO searchCriteria,
            long[] permittedAreas,
            Guid[] roleIds,
            long personid,
            bool isExternal = false,
            bool myTask = false,
            CancellationToken cancellationToken = default)
        {
            var lst = new List<RequestListDTO>();

            // My tasks
            if (searchCriteria.ListType == 0)
                lst = (await _reportService.GetRequestsListAsync(searchCriteria, permittedAreas, roleIds, false, true)).ToList();
            // All under processing  Requests
            else if (searchCriteria.ListType == 1)
                lst = (await _reportService.GetRequestsListAsync(searchCriteria, permittedAreas, roleIds, false, false)).ToList();
            // All Closed Requests
            else if (searchCriteria.ListType == 4)
                lst = (  await _reportService.GetClosedRequestsListAsync(searchCriteria, permittedAreas, roleIds, false)).ToList();
            #region Transferred Requests

                // All Transferred Requests assigned to logged in user
            else if (searchCriteria.ListType == 5)
                lst = (await _reportService.GetTransferedRequestsListAsync(searchCriteria, permittedAreas, roleIds, personid)).ToList();

            #endregion

            #region External Requests

            // New External Requests
            if (searchCriteria.ListType == 2)
                lst = (await _reportService.GetRequestsListAsync(searchCriteria, permittedAreas, roleIds, true, false)).ToList();
            //Existing External Requests
            else if (searchCriteria.ListType == 3)
                lst = (await _reportService.GetClosedRequestsListAsync(searchCriteria, permittedAreas, roleIds, true)).ToList();

            #endregion


            return lst;
        }

        
    }
} 