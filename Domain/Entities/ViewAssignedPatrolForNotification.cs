using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewAssignedPatrolForNotification
{
    public string? IncidentGeneratedNumber { get; set; }

    public long IncidentId { get; set; }

    public Guid? IncWf { get; set; }

    public long DispatchActivityId { get; set; }

    public long ActivityItemId { get; set; }

    public long PatrolId { get; set; }

    public Guid? ActivityItemWf { get; set; }

    public long? PatrolStatus { get; set; }
}
