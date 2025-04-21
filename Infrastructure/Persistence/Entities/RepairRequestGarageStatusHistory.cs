using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairRequestGarageStatusHistory
{
    public long Id { get; set; }

    public long RepairRequestGarageId { get; set; }

    public int? OldStatus { get; set; }

    public int NewStatus { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public virtual Person? LastModifiedByNavigation { get; set; }

    public virtual RepairStatusDim NewStatusNavigation { get; set; } = null!;

    public virtual RepairStatusDim? OldStatusNavigation { get; set; }

    public virtual RepairRequestGarage RepairRequestGarage { get; set; } = null!;
}
