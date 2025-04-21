using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewSupervisorMapIncidentsForAll
{
    public string? IncidentGeneratedNumber { get; set; }

    public long IncidentId { get; set; }

    public long? TrafficExpertId { get; set; }

    public long? PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public string TrafficExpertName { get; set; } = null!;

    public int StatusId { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long AreaId { get; set; }

    public DateTime? ServiceCallArrivedDate { get; set; }

    public string? StatusDesc { get; set; }

    public string? Address { get; set; }

    public string? AreaName { get; set; }

    public string? IncidentType { get; set; }

    public string? Priority { get; set; }

    public string? IncidentDescription { get; set; }

    public DateTime? PoliceDateTime { get; set; }

    public string? CallerName { get; set; }

    public double? PatrolLat { get; set; }

    public double? PatrolLon { get; set; }

    public string CallerMobile { get; set; } = null!;
}
