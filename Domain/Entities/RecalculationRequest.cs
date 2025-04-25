using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RecalculationRequest
{
    public long RecalculationRequestId { get; set; }

    public int? ReportId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public string? RequestDetails { get; set; }

    public long? CreatedBy { get; set; }

    public int? RequestStatusId { get; set; }

    public int? RecalculationRequestTypeId { get; set; }

    public string? RecalculationRequestTypeCommect { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<RecalculationReportChengeLog> RecalculationReportChengeLogs { get; set; } = new List<RecalculationReportChengeLog>();

    public virtual ICollection<RecalculationRequestAttachment> RecalculationRequestAttachments { get; set; } = new List<RecalculationRequestAttachment>();

    public virtual RecalculationRequestTypeDim? RecalculationRequestType { get; set; }

    public virtual Report? Report { get; set; }

    public virtual RecalculationStatusDim? RequestStatus { get; set; }
}
