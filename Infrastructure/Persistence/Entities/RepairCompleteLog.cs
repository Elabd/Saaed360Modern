using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairCompleteLog
{
    public long Id { get; set; }

    public DateTime ActionDate { get; set; }

    public long RepairRequestId { get; set; }

    public string Action { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public virtual RepairRequest RepairRequest { get; set; } = null!;
}
