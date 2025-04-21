using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewOpenIncidentDelayStatusHistory
{
    public long NotificationId { get; set; }

    public long IncidentId { get; set; }

    public string? NotificationType { get; set; }

    public DateTime? NotificationDateTime { get; set; }
}
