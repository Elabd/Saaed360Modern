using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewPatrolOnMission
{
    public long PatrolId { get; set; }

    public bool IsOnMission { get; set; }

    public DateTime? ActivityDate { get; set; }
}
