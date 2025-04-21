using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccsupervisorSupport
{
    public long IncidentId { get; set; }

    public long ActivityId { get; set; }

    public long ActivityItemId { get; set; }

    public bool? IsExternal { get; set; }

    public long AreaId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public long? OrganizationId { get; set; }

    public string? Name { get; set; }
}
