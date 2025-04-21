using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MissionPatrolStepDim
{
    public int MissionPatrolStepId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool Visible { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<EscortMissionPatrolStep> EscortMissionPatrolSteps { get; set; } = new List<EscortMissionPatrolStep>();
}
