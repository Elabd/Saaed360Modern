using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VIncidentWithAreaGroupList
{
    public long IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentDate { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public long? EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public long? AreaId { get; set; }

    public string? AreaName { get; set; }

    public string? IncidentPriority { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public string? IncidentDescription { get; set; }

    public string CallerTakerName { get; set; } = null!;

    public string DispatcherName { get; set; } = null!;

    public string AreaGroupName { get; set; } = null!;

    public string TrafficExpertName { get; set; } = null!;

    public int? AreaGroupId { get; set; }

    public string? GroupCode { get; set; }

    public string ReportNumber { get; set; } = null!;

    public DateTime? ReportDate { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public string? Address { get; set; }

    public string? SourceName { get; set; }

    public string? IncidentType { get; set; }

    public string? ControlCenterName { get; set; }

    public string GroupCodeName { get; set; } = null!;
}
