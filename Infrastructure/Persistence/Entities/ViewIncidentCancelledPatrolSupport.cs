using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentCancelledPatrolSupport
{
    public long IncidentId { get; set; }

    public Guid? IncidentWorkflow { get; set; }

    public long DispatchId { get; set; }

    public Guid? DispatchWorkflow { get; set; }

    public long ActivityItemId { get; set; }

    public Guid? PatrolWorkFlow { get; set; }

    public long? CurrentStatusId { get; set; }
}
