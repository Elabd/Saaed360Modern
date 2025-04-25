using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PoliceIncident
{
    public long RequestId { get; set; }

    public string? PoliceIncidentId { get; set; }

    public int IncidentPriorityId { get; set; }

    public int IncidentTypeId { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public string? Description { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }
}
