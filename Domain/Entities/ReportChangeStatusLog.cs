using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportChangeStatusLog
{
    public long LogId { get; set; }

    public int ReportId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDatetime { get; set; }

    public int? OldStatus { get; set; }

    public int? NewStatus { get; set; }

    public int? AuditTrailTableId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ReportStatusDim? NewStatusNavigation { get; set; }

    public virtual ReportStatusDim? OldStatusNavigation { get; set; }

    public virtual Report Report { get; set; } = null!;
}
