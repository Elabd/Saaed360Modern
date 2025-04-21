using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortMissionPatrolStep
{
    public long EscortMissionPatrolStepId { get; set; }

    public long EscortMissionPatrolId { get; set; }

    public int MissionPatrolStepId { get; set; }

    public string? Notes { get; set; }

    public int? EscortRejectionReasonId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public virtual EscortMissionPatrol EscortMissionPatrol { get; set; } = null!;

    public virtual EscortRejectionReasonDim? EscortRejectionReason { get; set; }

    public virtual MissionPatrolStepDim MissionPatrolStep { get; set; } = null!;
}
