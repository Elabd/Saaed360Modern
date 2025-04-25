using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissionStepDim
{
    public int MissionStepId { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }

    public virtual ICollection<EscortMissionStep> EscortMissionSteps { get; set; } = new List<EscortMissionStep>();
}
