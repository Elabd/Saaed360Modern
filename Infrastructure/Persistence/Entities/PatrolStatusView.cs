using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PatrolStatusView
{
    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public string? Name { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public DateTime? NotificationTime { get; set; }
}
