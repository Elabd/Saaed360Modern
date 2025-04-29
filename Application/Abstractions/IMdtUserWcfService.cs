using System.ServiceModel;
using System.Threading.Tasks;
using Saaed360Modern.Contracts.Wcf.MdtUserServiceRef; // Ensure this matches the namespace in Contracts/Wcf/MdtUserServiceRef/Reference.cs

namespace Application.Abstractions;

// Updated interface to include all methods found in MdtUserServiceClient
public interface IMdtUserWcfService
{
    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/SaveTemporaryLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/SaveTemporaryLogoutRequestResponse")]
    System.Threading.Tasks.Task<MdtUserResponse> SaveTemporaryLogoutRequestAsync(MdtUserRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/ConfirmTemporaryLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/ConfirmTemporaryLogoutRequestResponse")]
    System.Threading.Tasks.Task<AdminResponse> ConfirmTemporaryLogoutRequestAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/RejectTemporaryLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/RejectTemporaryLogoutRequestResponse")]
    System.Threading.Tasks.Task<AdminResponse> RejectTemporaryLogoutRequestAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetRejectionCategory", ReplyAction = "http://tempuri.org/IMdtUserService/GetRejectionCategoryResponse")]
    System.Threading.Tasks.Task<ActivityReasonDto[]> GetRejectionCategoryAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/SaveTSIncident", ReplyAction = "http://tempuri.org/IMdtUserService/SaveTSIncidentResponse")]
    System.Threading.Tasks.Task<long> SaveTSIncidentAsync(TSIncidentDto incidentRequestSendDto);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetTSDispatcherIncident", ReplyAction = "http://tempuri.org/IMdtUserService/GetTSDispatcherIncidentResponse")]
    System.Threading.Tasks.Task<DispatcherSendDto> GetTSDispatcherIncidentAsync(long incidentID);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetAttendedPatrols", ReplyAction = "http://tempuri.org/IMdtUserService/GetAttendedPatrolsResponse")]
    System.Threading.Tasks.Task<AttendedPatrolResponse> GetAttendedPatrolsAsync(AttendedPatrolRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetAttendedPatrolByLoginId", ReplyAction = "http://tempuri.org/IMdtUserService/GetAttendedPatrolByLoginIdResponse")]
    System.Threading.Tasks.Task<AttendedPatrolResponse> GetAttendedPatrolByLoginIdAsync(AttendedPatrolRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetMDTLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/GetMDTLogoutRequestResponse")]
    System.Threading.Tasks.Task<MDTLogoutRequestResponse> GetMDTLogoutRequestAsync(MDTLogoutRequestRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetMDTLogoutRequestByRequestId", ReplyAction = "http://tempuri.org/IMdtUserService/GetMDTLogoutRequestByRequestIdResponse")]
    System.Threading.Tasks.Task<MDTLogoutRequestResponse> GetMDTLogoutRequestByRequestIdAsync(MDTLogoutRequestRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/SavePermanentLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/SavePermanentLogoutRequestResponse")]
    System.Threading.Tasks.Task<MdtUserResponse> SavePermanentLogoutRequestAsync(MdtUserRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/AcknowledgeMdtUserLogin", ReplyAction = "http://tempuri.org/IMdtUserService/AcknowledgeMdtUserLoginResponse")]
    System.Threading.Tasks.Task<AdminResponse> AcknowledgeMdtUserLoginAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/RejectLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/RejectLogoutRequestResponse")]
    System.Threading.Tasks.Task<AdminResponse> RejectLogoutRequestAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/ConfirmPermanentLogoutRequest", ReplyAction = "http://tempuri.org/IMdtUserService/ConfirmPermanentLogoutRequestResponse")]
    System.Threading.Tasks.Task<AdminResponse> ConfirmPermanentLogoutRequestAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/TempDismissMdtUser", ReplyAction = "http://tempuri.org/IMdtUserService/TempDismissMdtUserResponse")]
    System.Threading.Tasks.Task<AdminResponse> TempDismissMdtUserAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/DismissMdtUser", ReplyAction = "http://tempuri.org/IMdtUserService/DismissMdtUserResponse")]
    System.Threading.Tasks.Task<AdminResponse> DismissMdtUserAsync(AdminRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetManualLoginPatrol", ReplyAction = "http://tempuri.org/IMdtUserService/GetManualLoginPatrolResponse")]
    System.Threading.Tasks.Task<ManualLoginPatrolResponse> GetManualLoginPatrolAsync(ManualLoginPatrolRequest request);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/SaveManualLogin", ReplyAction = "http://tempuri.org/IMdtUserService/SaveManualLoginResponse")]
    System.Threading.Tasks.Task<bool> SaveManualLoginAsync(ManualAttandanceDTO[] PatrolsWithOfficers, long OperatorId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetIncidentCompromise", ReplyAction = "http://tempuri.org/IMdtUserService/GetIncidentCompromiseResponse")]
    System.Threading.Tasks.Task<CompromiseDTO> GetIncidentCompromiseAsync(string incidentId);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/SaveCompromise", ReplyAction = "http://tempuri.org/IMdtUserService/SaveCompromiseResponse")]
    System.Threading.Tasks.Task<CompromiseDTO> SaveCompromiseAsync(CompromiseDTO compromise);

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetDamageParts", ReplyAction = "http://tempuri.org/IMdtUserService/GetDamagePartsResponse")]
    System.Threading.Tasks.Task<DataItemDTO[]> GetDamagePartsAsync();

    [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IMdtUserService/GetVehicleTypes", ReplyAction = "http://tempuri.org/IMdtUserService/GetVehicleTypesResponse")]
    System.Threading.Tasks.Task<DataItemDTO[]> GetVehicleTypesAsync();
}

