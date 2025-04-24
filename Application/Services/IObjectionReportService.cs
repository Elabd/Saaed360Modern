using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.DTOs.Objection;
using Infrastructure.Persistence.Entities;

namespace Application.Services
{
    public interface IObjectionReportService
    {
        System.Threading.Tasks.Task<List<LookupModel>> GetObjectionRequestTypeAsync();
        System.Threading.Tasks.Task<List<ViewObjectionsPayment>> GetResultAsync(SearchObjectionDTO search);
        System.Threading.Tasks.Task<Objection> GetObjectionByIdAsync(long objectionId);
        System.Threading.Tasks.Task<List<SPObjection>> GetObjectionSourceAsync(string reportNumber, int languageId);
        System.Threading.Tasks.Task<ViewObjection> GetViewObjectionByIdAsync(long objectionId);
        System.Threading.Tasks.Task RejectObjectionAsync(int objId, string rejectionReason, long userId, int? requestTypeId, string selectedValue);
        System.Threading.Tasks.Task<long?> AddPaymentTransactionAsync(long objectionId, int requestTypeId);
        System.Threading.Tasks.Task<List<ViewObjectionCommentsDTO>> GetObjectionCommentsAsync(long objectionId);
        System.Threading.Tasks.Task AddObjectionLogAsync(ObjectionLog log);
        System.Threading.Tasks.Task<List<ViewCustomerObjectionDocumentsDTO>> GetCustomerObjectionDocumentsAsync(long objectionId);
        System.Threading.Tasks.Task<List<ViewObjectionDocumentsDTO>> GetObjectionDocumentsAsync(long objectionId);
        System.Threading.Tasks.Task<List<ObjectionLog>> GetObjectionLogsByIdAsync(long objectionId);
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
        System.Threading.Tasks.Task<int?> GetReportIdByReportNumberAsync(string reportNumber);
        System.Threading.Tasks.Task<List<Person>> GetPersonsByIdsAsync(List<long> personIds);
        System.Threading.Tasks.Task<List<ViewObjection>> GetResultObjectionsAsync(SearchObjectionDTO search);
        System.Threading.Tasks.Task<List<ObjectionStatusDim>> GetObjectionStatusAsync();
         System.Threading.Tasks.Task UpdateRepairPermissionAsync(long objectionId, string damagesDescription, List<int> damagedParts, EsVehicleInquiry inquiry);
        System.Threading.Tasks.Task<IEnumerable<LookupModel>> GetDamagedPartsAsync(long requestId);
        System.Threading.Tasks.Task<EsRepairPermission> GetRepairPermissionAsync(long requestId);
        System.Threading.Tasks.Task<EsInsuranceInquiryResult> GetInsuranceInquiryDataAsync(long requestId);
        System.Threading.Tasks.Task<EsVehicleInquiryResult> GetVehicleInquiryDataAsync(long requestId);
        System.Threading.Tasks.Task<int?> GetYearIdAsync(string year);
    }
}

