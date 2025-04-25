using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortMission
{
    public long EscortMissionId { get; set; }

    public long EscortId { get; set; }

    public int NumberOfPatrols { get; set; }

    public DateTime MissionDate { get; set; }

    public int? CurrentMissionStepId { get; set; }

    public DateTime CreationDateTime { get; set; }

    public DateTime? ModifictionDateTime { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? LocationFrom { get; set; }

    public string? LocationTo { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public string? Notes { get; set; }

    public bool IsPatrolUsed { get; set; }

    public virtual Escort Escort { get; set; } = null!;

    public virtual ICollection<EscortMissionEmployee> EscortMissionEmployees { get; set; } = new List<EscortMissionEmployee>();

    public virtual ICollection<EscortMissionPatrol> EscortMissionPatrols { get; set; } = new List<EscortMissionPatrol>();

    public virtual ICollection<EscortMissionStep> EscortMissionSteps { get; set; } = new List<EscortMissionStep>();
}
