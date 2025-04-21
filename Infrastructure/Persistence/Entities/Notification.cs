using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Notification
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? NotifyingRecordId { get; set; }

    public string? NotificationType { get; set; }

    public long? CreatedBy { get; set; }

    public bool? IsNotified { get; set; }

    public int? Criticality { get; set; }

    public DateTime? NotificationDateTime { get; set; }

    public long? IncidentId { get; set; }

    public string? NotificationConditions { get; set; }

    public long? PatrolId { get; set; }
}
