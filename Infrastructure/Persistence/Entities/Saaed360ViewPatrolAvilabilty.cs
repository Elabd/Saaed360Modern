using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Saaed360ViewPatrolAvilabilty
{
    public Guid? Identifier { get; set; }

    public long AreaId { get; set; }

    public long PatrolId { get; set; }

    public long? PatrolAssignmentId { get; set; }

    public bool? IsAvailable { get; set; }

    public long StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public string? DeviceCode { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? TrackerCode { get; set; }

    public DateTime? LocationDate { get; set; }

    public string? AreaName { get; set; }

    public string? SerialIdentification { get; set; }
}
