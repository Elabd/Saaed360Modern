using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairNotificationLog
{
    public long Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string Level { get; set; } = null!;

    public long? RepairNotificationId { get; set; }

    public long? RepairRequestId { get; set; }

    public string? Status { get; set; }

    public string Message { get; set; } = null!;

    public virtual RepairNotification? RepairNotification { get; set; }

    public virtual RepairRequest? RepairRequest { get; set; }
}
