using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportsReuploadLog
{
    public long Id { get; set; }

    public int? ReportId { get; set; }

    public int? ReportsReuploadReasonId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public virtual ReportsReuploadReasonsDim? ReportsReuploadReason { get; set; }
}
