using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Saaed360ViewIncidentSearchDetail
{
    public long IncidentId { get; set; }

    public DateTime? IncidentDate { get; set; }

    public string? IncidentNumber { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public long IncidentCategoryId { get; set; }

    public int? IncidentTypeId { get; set; }

    public int? IncidentPriorityId { get; set; }

    public string CallerTakerName { get; set; } = null!;

    public long CallTakerId { get; set; }

    public string DispatcherName { get; set; } = null!;

    public long DispatcherId { get; set; }

    public string TrafficExpertName { get; set; } = null!;

    public long? TrafficExpertId { get; set; }

    public long ControlCenterId { get; set; }

    public string? ControlCenterName { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime? ReportDate { get; set; }

    public string? IncidentDescription { get; set; }
}
