using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewDispatcherIncidentPatrol
{
    public Guid? Identifier { get; set; }

    public long OrganizationId { get; set; }

    public long? AreaId { get; set; }

    public long PatrolId { get; set; }

    public long? IncidentId { get; set; }

    public long? PatrolAssignmentId { get; set; }

    public bool? IsAvailable { get; set; }

    public long StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public bool? Delayed { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string DeviceCode { get; set; } = null!;

    public string PlateNumber { get; set; } = null!;

    public string? SectorName { get; set; }
}
