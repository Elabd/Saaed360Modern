using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportHeatMap
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDate { get; set; }

    public long IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public string? IncidentDescription { get; set; }

    public string CallerTakerName { get; set; } = null!;

    public string DispatcherName { get; set; } = null!;

    public string TrafficExpertName { get; set; } = null!;
}
