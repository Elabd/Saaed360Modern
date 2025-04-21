using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportRequest
{
    public long RequestId { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public string? RequestNumber { get; set; }

    public int? RequestTypeId { get; set; }

    public int? ReportId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? SourceOfModificationId { get; set; }

    public int? ResponsibilityId { get; set; }

    public bool? IsExternal { get; set; }

    public bool? IsTransfered { get; set; }

    public long? TransferedBy { get; set; }

    public DateTime? TransferDate { get; set; }

    public int? CancelReasonId { get; set; }

    public string? OtherCancelReason { get; set; }

    public long? ObjectionId { get; set; }

    public long? LinkedRequestId { get; set; }

    public int? RequestServiceTypeId { get; set; }

    public virtual CancelReasonDim? CancelReason { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Report? Report { get; set; }

    public virtual ICollection<ReportModification> ReportModifications { get; set; } = new List<ReportModification>();

    public virtual ICollection<ReportRequestClientDatum> ReportRequestClientData { get; set; } = new List<ReportRequestClientDatum>();

    public virtual ICollection<ReportRequestComment> ReportRequestComments { get; set; } = new List<ReportRequestComment>();

    public virtual ICollection<ReportRequestDocument> ReportRequestDocuments { get; set; } = new List<ReportRequestDocument>();

    public virtual RequestServiceTypeDim? RequestServiceType { get; set; }

    public virtual ReportRequestTypeDim? RequestType { get; set; }

    public virtual ReportModificationResponsibilityDim? Responsibility { get; set; }

    public virtual Person? TransferedByNavigation { get; set; }
}
