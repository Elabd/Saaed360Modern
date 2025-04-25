using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PendingPublicNotification
{
    public int ReportNotifierId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public string? Email { get; set; }
}
