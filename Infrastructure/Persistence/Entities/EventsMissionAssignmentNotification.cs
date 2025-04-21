using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventsMissionAssignmentNotification
{
    public long Id { get; set; }

    public long EventsMissionAssignmentId { get; set; }

    public string NotificationType { get; set; } = null!;

    public string NotificationStatus { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public virtual EventsMissionAssignment EventsMissionAssignment { get; set; } = null!;
}
