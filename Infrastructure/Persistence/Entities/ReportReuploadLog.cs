using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportReuploadLog
{
    public long LogId { get; set; }

    public long ReuploadedById { get; set; }

    public long? ReasonId { get; set; }

    public string? ReasonText { get; set; }

    public DateTime ReuploadedTime { get; set; }
}
