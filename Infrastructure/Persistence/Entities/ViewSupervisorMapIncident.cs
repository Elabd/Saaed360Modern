using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewSupervisorMapIncident
{
    public string? IncidentGeneratedNumber { get; set; }

    public long IncidentId { get; set; }

    public long? PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public int StatusId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long AreaId { get; set; }

    public DateTime? ServiceCallArrivedDate { get; set; }

    public string? StatusDesc { get; set; }

    public string? Address { get; set; }

    public string? AreaName { get; set; }
}
