using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.DTOs.Objection;
using Domain.Entities;

namespace Application.Abstractions
{
    public interface IObjectionService
    {
        Task<List<ViewObjection>> GetResultObjectionsAsync(SearchObjectionDTO search);
        Task<List<LookupModel>> GetObjectionRequestTypeAsync();
        Task<List<ViewObjectionsPayment>> GetResultAsync(SearchObjectionDTO search);
        Task<Objection> GetObjectionByIdAsync(long objectionId);
        Task<List<SPObjection>> GetObjectionSourceAsync(string reportNumber, int languageId);
        Task<ViewObjection> GetViewObjectionByIdAsync(long objectionId);
        System.Threading.Tasks.Task RejectObjectionAsync(int objId, string rejectionReason, long userId, int? requestTypeId, string selectedValue);
        Task<long?> AddPaymentTransactionAsync(long objectionId, int requestTypeId);
        Task<List<ViewObjectionCommentsDTO>> GetObjectionCommentsAsync(long objectionId);
        System.Threading.Tasks.Task AddObjectionLogAsync(ObjectionLog log);
        Task<List<ViewCustomerObjectionDocumentsDTO>> GetCustomerObjectionDocumentsAsync(long objectionId);
        Task<List<ViewObjectionDocumentsDTO>> GetObjectionDocumentsAsync(long objectionId);
        Task<List<ObjectionLog>> GetObjectionLogsByIdAsync(long objectionId);
        System.Threading.Tasks.Task AddObjectionCommentLogAsync(ObjectionCommentLog commentLog);
        System.Threading.Tasks.Task AddObjectionDocumentAsync(ObjectionDocument objectionDocument);
        System.Threading.Tasks.Task ConvertObjectionToCenterAsync(long objectionId, long departmentId, int reasonId, string centerComment, long userId);
        System.Threading.Tasks.Task UpdateObjectionStatusAsync(
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
            int? sourceOfRequestVehicleID = null);
        Task<int?> GetReportIdByReportNumberAsync(string reportNumber);
        Task<List<Person>> GetPersonsByIdsAsync(List<long> personIds);
        Task<List<ObjectionStatusDim>> GetObjectionStatusAsync();
        System.Threading.Tasks.Task UpdateRepairPermissionAsync(long objectionId, string damagesDescription, List<int> damagedParts, EsVehicleInquiry inquiry);
        Task<IEnumerable<LookupModel>> GetDamagedPartsAsync(long requestId);
        Task<EsRepairPermission> GetRepairPermissionAsync(long requestId);
        Task<EsInsuranceInquiryResult> GetInsuranceInquiryDataAsync(long requestId);
        Task<EsVehicleInquiryResult> GetVehicleInquiryDataAsync(long requestId);
        Task<int?> GetYearIdAsync(string year);
    }
} 