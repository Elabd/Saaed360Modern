using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedSupervisorMissionForTe
{
    public long PatrolId { get; set; }

    public bool IsOnMission { get; set; }

    public DateTime? MissionStartTime { get; set; }

    public DateTime? MissionEndTime { get; set; }

    public bool? IsCancelled { get; set; }

    public long AreaId { get; set; }

    public long? OrganizationId { get; set; }

    public string? OrganizationName { get; set; }
}
