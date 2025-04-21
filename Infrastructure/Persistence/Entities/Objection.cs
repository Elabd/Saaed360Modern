using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public class Objection
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }

    public long ObjectionId { get; set; }

    public int? ReportId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public string ObjectionSubject { get; set; } = null!;

    public string ObjectionBody { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public int ObjectionLanguage { get; set; }

    public int StatusId { get; set; }

    public int? RequestTypeId { get; set; }

    public string? Name { get; set; }

    public int? SourceOfRequestId { get; set; }

    public int? NationalityId { get; set; }

    public string? NationalId { get; set; }

    public string? OtherSourceOfRequest { get; set; }

    public string? NationalityTxt { get; set; }

    public int? ObjectionResultId { get; set; }

    public string? RejectionReason { get; set; }

    public bool? IsConvertedToCenter { get; set; }

    public long? DepartmentId { get; set; }

    public int? ReasonId { get; set; }

    public string? CenterComment { get; set; }

    public long? EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public string? VehicleNumber { get; set; }

    public int? RequestModificationId { get; set; }

    public string? OtherRequestModification { get; set; }

    public string? LicenceNumber { get; set; }

    public int? ExemptionRequestTypeId { get; set; }

    public long? CityId { get; set; }

    public string? CityName { get; set; }

    public string? Area { get; set; }

    public string? ReturnReason { get; set; }

    public int? SourceOfRequestVehicleId { get; set; }

    public bool IsNew { get; set; }

    public DateTime? IncidentApproximateDateFrom { get; set; }

    public DateTime? IncidentApproximateDateTo { get; set; }

    public int? RequestChannelId { get; set; }

    public long? ObjectionCustomerAdditionalDataId { get; set; }

    public int? PereferredCommunicationMethod { get; set; }

    public long? MobileUserId { get; set; }

    public virtual Organization? Department { get; set; }

    public virtual EsRepairPermission? EsRepairPermission { get; set; }

    public virtual ICollection<ObjectionCommentLog> ObjectionCommentLogs { get; set; } = new List<ObjectionCommentLog>();

    public virtual ObjectionCustomerAdditionalDatum? ObjectionCustomerAdditionalData { get; set; }

    public virtual ICollection<ObjectionCustomerDocument> ObjectionCustomerDocuments { get; set; } = new List<ObjectionCustomerDocument>();

    public virtual ICollection<ObjectionLocation> ObjectionLocations { get; set; } = new List<ObjectionLocation>();

    public virtual ICollection<ObjectionLog> ObjectionLogs { get; set; } = new List<ObjectionLog>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual CommunicationMethodsDim? PereferredCommunicationMethodNavigation { get; set; }

    public virtual ActivityReasonDim? Reason { get; set; }

    public virtual Report? Report { get; set; }

    public virtual ObjectionRequestChannelDim? RequestChannel { get; set; }
}
