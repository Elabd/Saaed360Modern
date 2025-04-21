using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortMissionPatrol
{
    public long EscortMissionPatrolId { get; set; }

    public long PatrolId { get; set; }

    public long EscortMissionId { get; set; }

    public int? CurrentMissionPatrolStepId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? ModifictionDateTime { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? Notes { get; set; }

    public bool IsPatrolUsed { get; set; }

    public virtual EscortMission EscortMission { get; set; } = null!;

    public virtual ICollection<EscortMissionCancelationLog> EscortMissionCancelationLogs { get; set; } = new List<EscortMissionCancelationLog>();

    public virtual ICollection<EscortMissionPatrolEmployee> EscortMissionPatrolEmployees { get; set; } = new List<EscortMissionPatrolEmployee>();

    public virtual ICollection<EscortMissionPatrolStep> EscortMissionPatrolSteps { get; set; } = new List<EscortMissionPatrolStep>();

    public virtual Item Patrol { get; set; } = null!;
}
