using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortMissionStep
{
    public long EscortMissionStepId { get; set; }

    public long EscortMissionId { get; set; }

    public int MissionStepId { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual EscortMission EscortMission { get; set; } = null!;

    public virtual MissionStepDim MissionStep { get; set; } = null!;
}
