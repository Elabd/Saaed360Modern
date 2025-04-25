using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewPatrol
{
    public long OrganizationId { get; set; }

    public long PatrolId { get; set; }

    public string? PatroCode { get; set; }

    public long? IncidentId { get; set; }

    public long? PatrolAssignmentId { get; set; }

    public bool? IsAssigned { get; set; }

    public long? StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public bool? Delayed { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? DeviceCode { get; set; }

    public string? TrackerCode { get; set; }

    public DateTime? LocationDate { get; set; }
}
