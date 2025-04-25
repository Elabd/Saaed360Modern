using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortMissionPatrolEmployee
{
    public long EscortMissionPatrolEmployeeId { get; set; }

    public long? EscortMissionPatrolId { get; set; }

    public long? PersonId { get; set; }

    public virtual EscortMissionPatrol? EscortMissionPatrol { get; set; }

    public virtual Person? Person { get; set; }
}
