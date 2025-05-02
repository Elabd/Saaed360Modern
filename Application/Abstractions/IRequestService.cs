using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.DTOs;
using Saaed360Modern.Contracts.Wcf;

namespace Application.Abstractions
{
    public interface IRequestService
    {
        Task<IEnumerable<LookupDto>> GetSourceOfModificationAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<LookupDto>> GetRequestTypeListAsync(CancellationToken cancellationToken = default);
        Task<IEnumerable<RequestListDTO>> GetRequestListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleIds, long personid, bool isExternal = false, bool myTask = false, CancellationToken cancellationToken = default);
        
        // New methods
        Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleIds );
        Task<ReportRequestDto> GetTransferredRequestByIdAsync(long requestId, CancellationToken cancellationToken = default);
        Task<bool> TransferRequestAsync(ReportRequestDto request, CancellationToken cancellationToken = default);
        Task<bool> CanTransferRequestAsync(long requestId, CancellationToken cancellationToken = default);
        Task<bool> SaveRequestAsync(ReportRequestDto request, CancellationToken cancellationToken = default);
        Task<IEnumerable<DifferentValues>> GetDifferentsAsync(ReportDTO modifiedReport, CancellationToken cancellationToken = default);
    }
} 