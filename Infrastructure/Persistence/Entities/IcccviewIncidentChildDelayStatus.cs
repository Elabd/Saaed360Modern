using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewIncidentChildDelayStatus
{
    public long IncidentId { get; set; }

    public long PatrolAssignmentId { get; set; }

    public Guid? ChildWorkFlowId { get; set; }

    public DateTime? ActivityCreatedDate { get; set; }

    public string? PatrolType { get; set; }

    public string? Description { get; set; }

    public string? PatrolDelayStatus { get; set; }
}
