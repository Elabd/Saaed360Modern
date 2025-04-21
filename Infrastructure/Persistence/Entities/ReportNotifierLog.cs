using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportNotifierLog
{
    public long ReportNotifierLogId { get; set; }

    public long ReportNotifierId { get; set; }

    public long ReportId { get; set; }

    public string Email { get; set; } = null!;

    public DateTime SendDate { get; set; }

    public string? ErrorMessage { get; set; }
}
