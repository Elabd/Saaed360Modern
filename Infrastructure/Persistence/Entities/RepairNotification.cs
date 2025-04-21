using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairNotification
{
    public long Id { get; set; }

    public long RepairRequestId { get; set; }

    public string? Recipients { get; set; }

    public int NotificationType { get; set; }

    public bool IsSchedualed { get; set; }

    public DateTime? SchedualTime { get; set; }

    public string? Arguments { get; set; }

    public string Language { get; set; } = null!;

    public bool IsHandled { get; set; }

    public bool IsSent { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<RepairNotificationLog> RepairNotificationLogs { get; set; } = new List<RepairNotificationLog>();

    public virtual RepairRequest RepairRequest { get; set; } = null!;
}
