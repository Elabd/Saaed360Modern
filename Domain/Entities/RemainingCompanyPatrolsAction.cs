using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RemainingCompanyPatrolsAction
{
    public long Id { get; set; }

    public long EscortId { get; set; }

    public int PatrolsCount { get; set; }

    public int RemainingCompanyPatrolsActionTypeId { get; set; }

    public long CreatedBy { get; set; }

    public DateTime CreationDateTime { get; set; }

    public virtual Escort Escort { get; set; } = null!;

    public virtual RemainingCompanyPatrolsActionType RemainingCompanyPatrolsActionType { get; set; } = null!;
}
