using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewPatrolDelayStatus
{
    public long PatrolAssignmentId { get; set; }

    public DateTime? IncidentCreatedDate { get; set; }

    public string? PatrolDelayStatus { get; set; }
}
