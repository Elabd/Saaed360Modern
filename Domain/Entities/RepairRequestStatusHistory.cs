using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairRequestStatusHistory
{
    public long Id { get; set; }

    public long RepairRequestId { get; set; }

    public int? OldStatus { get; set; }

    public int NewStatus { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public virtual RepairStatusDim NewStatusNavigation { get; set; } = null!;

    public virtual RepairStatusDim? OldStatusNavigation { get; set; }

    public virtual RepairRequest RepairRequest { get; set; } = null!;
}
