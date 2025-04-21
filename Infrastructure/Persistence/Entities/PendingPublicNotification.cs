using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PendingPublicNotification
{
    public int ReportNotifierId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public string? Email { get; set; }
}
