using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentRelatedPatol
{
    public string? IncidentGeneratedNumber { get; set; }

    public long IncidentId { get; set; }

    public Guid? IncWf { get; set; }

    public long DispatchActivityId { get; set; }

    public long ActivityItemId { get; set; }

    public long PatrolId { get; set; }

    public long? CurrentStatusId { get; set; }

    public Guid? ActivityItemWf { get; set; }
}
