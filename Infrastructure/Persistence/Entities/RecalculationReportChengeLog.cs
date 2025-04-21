using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RecalculationReportChengeLog
{
    public long Id { get; set; }

    public long? RecalculationRequestId { get; set; }

    public bool? IsChanged { get; set; }

    public int? ReportId { get; set; }

    public string? OldReportNumber { get; set; }

    public string? NewReportNumber { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public virtual RecalculationRequest? RecalculationRequest { get; set; }

    public virtual Report? Report { get; set; }
}
