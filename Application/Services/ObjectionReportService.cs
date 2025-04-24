using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.DTOs.Objection;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Application.Services.Lookup;
using Domain.Enums;
using Application.Services.Auth;

namespace Application.Services
{
    public class ObjectionReportService : IObjectionReportService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ObjectionReportService> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILookupService _lookupService;
        private readonly ICurrentUserService _currentUserService;



        public ObjectionReportService(
            ApplicationDbContext context,
            ILogger<ObjectionReportService> logger,
            IConfiguration configuration,
            ILookupService lookupService ,
            ICurrentUserService currentUserService)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _lookupService = lookupService ?? throw new ArgumentNullException(nameof(lookupService));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
        }

        public async System.Threading.Tasks.Task<List<LookupModel>> GetObjectionRequestTypeAsync()
        {
            try
            {
                var types = new List<int>() { 4, 7 };
                return await _context.ObjectionRequestTypes
                    .Where(e => types.Contains(e.RequestTypeId))
                    .Select(e => new LookupModel
                    {
                        Id = e.RequestTypeId,
                        Description = e.ArabicDescription
                    })
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection request types");
                return new List<LookupModel>();
            }
        }

        public async System.Threading.Tasks.Task<List<ViewObjectionsPayment>> GetResultAsync(SearchObjectionDTO search)
        {
            try
            {
               var _currentUser =  _currentUserService.GetCurrentUser();
                var query = _context.ViewObjectionsPayments.AsQueryable();

                if (search.from.HasValue)
                    query = query.Where(x => x.ObjectionDate >= search.from);
                if (search.to.HasValue)
                {
                    var newdate = search.to.Value.AddDays(1);
                    query = query.Where(x => x.ObjectionDate <= newdate);
                }
                if (search.statusId > 0)
                {
                    if (search.statusId == 2)
                        query = query.Where(x => x.PaymentStatusId == 2);
                    else
                        query = query.Where(x => x.PaymentStatusId != 2);
                }
                if (!string.IsNullOrEmpty(search.ReportNumber))
                    query = query.Where(x => x.ReportNumber == search.ReportNumber);
                if (search.RequestNumber > 0)
                    query = query.Where(x => x.ObjectionId == search.RequestNumber);
                if (search.typeId > 0)
                    query = query.Where(x => x.RequestTypeId == search.typeId);
                if (search.areaId != null && search.areaId.Any())
                {
                    query = query.Where(x => x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value));
                }
                else if (!IsSuperUser(search.UserName))
                {
                    
                    var emirates =  _lookupService.GetEmiratesByUserId(_currentUser.UserId);
                    var emirateIds = emirates.Select(x => x.Id);
                    query = query.Where(x =>
                        (x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value)) ||
                        (!x.AreaId.HasValue && !x.ObjectionEmirateId.HasValue) ||
                        (x.ObjectionEmirateId.HasValue && emirateIds.Contains(x.ObjectionEmirateId.Value)) ||
                        x.AreaId == null);
                }

                return await query.OrderByDescending(x => x.ObjectionId).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection results");
                return new List<ViewObjectionsPayment>();
            }
        }

        public async System.Threading.Tasks.Task<Objection> GetObjectionByIdAsync(long objectionId)
        {
            try
            {
                return await _context.Objections
                    .Include(o => o.Report)
                    .FirstOrDefaultAsync(x => x.ObjectionId == objectionId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection by id: {ObjectionId}", objectionId);
                return null;
            }
        }

        public async System.Threading.Tasks.Task<List<SPObjection>> GetObjectionSourceAsync(string reportNumber, int languageId)
        {
            try
            {
                return await _context.Database
                    .SqlQueryRaw<SPObjection>("SP_ObjectionSource @ReportNumber = @p0, @LanguageId = @p1", reportNumber, languageId)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection source for report: {ReportNumber}", reportNumber);
                return new List<SPObjection>();
            }
        }

        public async System.Threading.Tasks.Task<ViewObjection> GetViewObjectionByIdAsync(long objectionId)
        {
            try
            {
                return await _context.ViewObjections
                    .FirstOrDefaultAsync(x => x.ObjectionId == objectionId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting view objection by id: {ObjectionId}", objectionId);
                return null;
            }
        }

        public async System.Threading.Tasks.Task RejectObjectionAsync(int objId, string rejectionReason, long userId, int? requestTypeId, string selectedValue)
        {
            try
            {
                var obj = await _context.Objections.FirstOrDefaultAsync(x => x.ObjectionId == objId);
                if (obj != null)
                {
                    obj.StatusId = (int)ObjectionStatus.REJECTED;
                    obj.ObjectionResultId = (int)ObjectionResult.REJECTED;
                    obj.RejectionReason = rejectionReason;
                    if (requestTypeId == 7 && !string.IsNullOrEmpty(selectedValue) && obj.IsNew)
                        obj.SourceOfRequestVehicleId = int.Parse(selectedValue);

                    await _context.ObjectionLogs.AddAsync(new ObjectionLog
                    {
                        LogDateTime = DateTime.Now,
                        NewStatusId = (int)ObjectionStatus.REJECTED,
                        OldStatusId = (int)ObjectionStatus.INPROGREES,
                        ObjectionId = obj.ObjectionId,
                        PersonId = userId,
                        IsPoliceAction = false
                    });

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error rejecting objection: {ObjectionId}", objId);
                throw;
            }
        }

        public async System.Threading.Tasks.Task<long?> AddPaymentTransactionAsync(long objectionId, int requestTypeId)
        {
            try
            {
                var obj = await _context.Objections.FirstOrDefaultAsync(x => x.ObjectionId == objectionId);
                if (obj == null) return null;

                int userAccountId = int.Parse(_configuration["UserAccountId"]);
                var reportVehicle = await _context.ReportVehicleData
                    .FirstOrDefaultAsync(r => r.ReportId == obj.ReportId && r.VehicleDataId == obj.SourceOfRequestVehicleId);
                var paymentType = await _context.PaymentRequestTypeDims
                    .FirstOrDefaultAsync(t => t.Code == requestTypeId);

                if (paymentType == null)
                    throw new Exception("No payment type");

                var transaction = new PaymentTransaction
                {
                    ObjectionId = obj.ObjectionId,
                    ReportVehicleDataId = reportVehicle?.ReportVehicleDataId,
                    PaymentRequestTypeId = paymentType.Id,
                    PaymentStatusId = (int)PaymentStatus.Initiated,
                    CreationDateTime = DateTime.Now,
                    PaymentUserAccountId = userAccountId,
                };

                await _context.PaymentTransactions.AddAsync(transaction);
                await _context.SaveChangesAsync();

                return transaction.TransactionId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding payment transaction for objection: {ObjectionId}", objectionId);
                throw;
            }
        }

        public async System.Threading.Tasks.Task<List<ViewObjectionCommentsDTO>> GetObjectionCommentsAsync(long objectionId)
        {
            try
            {
                var comments = await _context.ViewObjectionComments
                    .Where(x => x.ObjectionId == objectionId)
                    .OrderByDescending(x => x.CreationTime)
                    .ToListAsync();

                return comments.Select(item => new ViewObjectionCommentsDTO
                {
                    CommentText = item.CommentText,
                    CreationTime = item.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    ObjectionId = item.ObjectionId,
                    PersonId = item.PersonId,
                    PersonName = item.PersonName
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection comments for objection: {ObjectionId}", objectionId);
                return new List<ViewObjectionCommentsDTO>();
            }
        }

        public async System.Threading.Tasks.Task AddObjectionLogAsync(ObjectionLog log)
        {
            try
            {
                await _context.ObjectionLogs.AddAsync(log);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding objection log");
                throw;
            }
        }

        public async System.Threading.Tasks.Task<List<ViewCustomerObjectionDocumentsDTO>> GetCustomerObjectionDocumentsAsync(long objectionId)
        {
            try
            {
                var list = await _context.ObjectionCustomerDocuments
                    .Where(x => x.ObjectionId == objectionId)
                    .ToListAsync();

                var types = await _context.ObjectionCustomerDocumentTypeDims.ToListAsync();

                return (from objection in list
                       join type in types on objection.ObjectionCustomerDocumentTypeId equals type.ObjectionCustomerDocumentTypeId into newList
                       from type in newList.DefaultIfEmpty()
                       select new ViewCustomerObjectionDocumentsDTO
                       {
                           CreationTime = objection.CreationDate.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                           DocName = objection.DocumentName,
                           DocPath = _configuration["ObjectionDocumentPath"] + @"/" + objection.ObjectionId + @"/" + objection.DocumentName,
                           ObjectionId = objection.ObjectionId.Value,
                           PersonName = objection.ClientName,
                           Type = type?.DescriptionAr
                       }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting customer objection documents for objection: {ObjectionId}", objectionId);
                return new List<ViewCustomerObjectionDocumentsDTO>();
            }
        }

        public async System.Threading.Tasks.Task<List<ViewObjectionDocumentsDTO>> GetObjectionDocumentsAsync(long objectionId)
        {
            try
            {
                var documents = await _context.ViewObjectionDocuments
                    .Where(x => x.ObjectionId == objectionId)
                    .OrderByDescending(x => x.CreationTime)
                    .ToListAsync();

                return documents.Select(item => new ViewObjectionDocumentsDTO
                {
                    CreationTime = item.CreationTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    DocName = item.DocName,
                    ObjectionId = item.ObjectionId,
                    PersonName = item.PersonName
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection documents for objection: {ObjectionId}", objectionId);
                return new List<ViewObjectionDocumentsDTO>();
            }
        }

        public async System.Threading.Tasks.Task<List<ObjectionLog>> GetObjectionLogsByIdAsync(long objectionId)
        {
            try
            {
                return await _context.ObjectionLogs
                    .Where(x => x.ObjectionId == objectionId)
                    .OrderBy(x => x.LogDateTime)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection logs for objection: {ObjectionId}", objectionId);
                return new List<ObjectionLog>();
            }
        }

        public async System.Threading.Tasks.Task AddObjectionCommentLogAsync(ObjectionCommentLog commentLog)
        {
            try
            {
                await _context.ObjectionCommentLogs.AddAsync(commentLog);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding objection comment log");
                throw;
            }
        }

        public async System.Threading.Tasks.Task AddObjectionDocumentAsync(ObjectionDocument objectionDocument)
        {
            try
            {
                await _context.ObjectionDocuments.AddAsync(objectionDocument);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding objection document");
                throw;
            }
        }

        public async System.Threading.Tasks.Task ConvertObjectionToCenterAsync(long objectionId, long departmentId, int reasonId, string centerComment, long userId)
        {
            try
            {
                var currentObjection = await _context.Objections.FirstOrDefaultAsync(x => x.ObjectionId == objectionId);
                if (currentObjection != null)
                {
                    currentObjection.IsConvertedToCenter = true;
                    currentObjection.DepartmentId = departmentId;
                    currentObjection.ReasonId = reasonId;
                    currentObjection.CenterComment = centerComment;

                    await _context.ObjectionLogs.AddAsync(new ObjectionLog
                    {
                        LogDateTime = DateTime.Now,
                        NewStatusId = (int)ObjectionStatus.CONVERTTOCENTER,
                        OldStatusId = currentObjection.StatusId,
                        ObjectionId = objectionId,
                        PersonId = userId
                    });

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error converting objection to center: {ObjectionId}", objectionId);
                throw;
            }
        }

        public async System.Threading.Tasks.Task UpdateObjectionStatusAsync(
            long objectionId,
            int newStatusId,
            int oldStatusId,
            long userId,
            int? requestTypeId = null,
            string rejectionReason = null,
            string returnReason = null,
            string reportNumber = null,
            string selectedValue = null,
            bool isNew = false,
            int? sourceOfRequestVehicleID = null)
        {
            try
            {
                var obj = await _context.Objections.FirstOrDefaultAsync(x => x.ObjectionId == objectionId);
                if (obj != null)
                {
                    obj.StatusId = newStatusId;
                    obj.ObjectionResultId = newStatusId == (int)ObjectionStatus.REJECTED ? (int)ObjectionResult.REJECTED : obj.ObjectionResultId;
                    obj.RejectionReason = rejectionReason;
                    obj.ReturnReason = returnReason;

                    if (requestTypeId == 7 && !string.IsNullOrEmpty(selectedValue) && isNew)
                        obj.SourceOfRequestVehicleId = int.Parse(selectedValue);

                    if (!string.IsNullOrEmpty(reportNumber))
                    {
                        var reportObj = await _context.Reports.FirstOrDefaultAsync(x => x.ReportNumber == reportNumber);
                        if (reportObj != null)
                            obj.ReportId = reportObj.ReportId;
                    }

                    await _context.ObjectionLogs.AddAsync(new ObjectionLog
                    {
                        LogDateTime = DateTime.Now,
                        NewStatusId = newStatusId,
                        OldStatusId = oldStatusId,
                        ObjectionId = obj.ObjectionId,
                        PersonId = userId,
                        IsPoliceAction = false
                    });

                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating objection status for objection: {ObjectionId}", objectionId);
                throw;
            }
        }

        public async System.Threading.Tasks.Task<int?> GetReportIdByReportNumberAsync(string reportNumber)
        {
            try
            {
                var report = await _context.Reports
                    .FirstOrDefaultAsync(r => r.ReportNumber == reportNumber);
                return report?.ReportId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting report id for report number: {ReportNumber}", reportNumber);
                return null;
            }
        }

        public async System.Threading.Tasks.Task<List<Person>> GetPersonsByIdsAsync(List<long> personIds)
        {
            try
            {
                return await _context.People
                    .Where(x => personIds.Contains(x.PersonId))
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting persons by ids");
                return new List<Person>();
            }
        }

        public async System.Threading.Tasks.Task<List<ViewObjection>> GetResultObjectionsAsync(SearchObjectionDTO search)
        {
            try
            {
                var query = _context.ViewObjections.AsQueryable();

                if (search.from.HasValue)
                    query = query.Where(x => x.ObjectionDate >= search.from);
                if (search.to.HasValue)
                    query = query.Where(x => x.ObjectionDate <= search.to);
                if (search.statusId > 0)
                {
                    if (search.statusId == 1)
                        query = query.Where(x => x.StatusId == 1 || x.StatusId == 7);
                    else
                        query = query.Where(x => x.StatusId == search.statusId);
                }
                if (!string.IsNullOrEmpty(search.ReportNumber))
                    query = query.Where(x => x.ReportNumber == search.ReportNumber);
                if (search.RequestNumber > 0)
                    query = query.Where(x => x.ObjectionId == search.RequestNumber);
                if (search.typeId > 0)
                    query = query.Where(x => x.RequestTypeId == search.typeId);
                if (search.areaId != null && search.areaId.Any())
                {
                    query = query.Where(x => x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value));
                }
                else if (!IsSuperUser(search.UserName))
                {
                    var _currentUser = _currentUserService.GetCurrentUser();
                    var emirates =  _lookupService.GetEmiratesByUserId(_currentUser.UserId);
                    var emirateIds = emirates.Select(x => x.Id);
                    query = query.Where(x =>
                        (x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value)) ||
                        (!x.AreaId.HasValue && !x.ObjectionEmirateId.HasValue) ||
                        (x.ObjectionEmirateId.HasValue && emirateIds.Contains(x.ObjectionEmirateId.Value)) ||
                        x.AreaId == null);
                }

                return await query.OrderBy(x => x.ObjectionDate).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection results");
                return new List<ViewObjection>();
            }
        }

        public async System.Threading.Tasks.Task<List<ObjectionStatusDim>> GetObjectionStatusAsync()
        {
            try
            {
                return await _context.ObjectionStatusDims.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection status");
                return new List<ObjectionStatusDim>();
            }
        }

        private bool IsSuperUser(string userName)
        {
            if (string.IsNullOrEmpty(userName))
                return false;

            var superUsers = GetSuperUsers();
            return superUsers.Contains(userName);
        }

        private List<string> GetSuperUsers()
        {
            try
            {
                var keyConfig = _configuration["SuperUsers"];
                if (string.IsNullOrEmpty(keyConfig))
                    return new List<string>();

                return keyConfig.Contains(",")
                    ? keyConfig.Split(',').ToList()
                    : new List<string> { keyConfig };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting super users from configuration");
                return new List<string>();
            }
        }

        public System.Threading.Tasks.Task UpdateRepairPermissionAsync(long objectionId, string damagesDescription, List<int> damagedParts, EsVehicleInquiry inquiry)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<LookupModel>> GetDamagedPartsAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<EsRepairPermission> GetRepairPermissionAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<EsInsuranceInquiryResult> GetInsuranceInquiryDataAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<EsVehicleInquiryResult> GetVehicleInquiryDataAsync(long requestId)
        {
            throw new NotImplementedException();
        }

        public Task<int?> GetYearIdAsync(string year)
        {
            throw new NotImplementedException();
        }
    }
} 