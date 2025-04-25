using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VSaaedTsgetClosedIncidentList
{
    public long IncidentId { get; set; }

    public DateTime? IncidentDate { get; set; }

    public long SourceId { get; set; }

    public string? IncidentNumber { get; set; }

    public long? ClosedIncidentActivityId { get; set; }

    public string CallerName { get; set; } = null!;

    public string CallerNumber { get; set; } = null!;

    public long IncidentCategoryId { get; set; }

    public int? IncidentTypeId { get; set; }

    public int? IncidentPriorityId { get; set; }

    public string? IncidentPriority { get; set; }

    public string CallerTakerName { get; set; } = null!;

    public long CallTakerId { get; set; }

    public string DispatcherName { get; set; } = null!;

    public long? DispatcherId { get; set; }

    public string TrafficExpertName { get; set; } = null!;

    public long? TrafficExpertId { get; set; }

    public long? ControlCenterId { get; set; }

    public string? ControlCenterName { get; set; }

    public long? AreaId { get; set; }

    public long? EmirateId { get; set; }

    public string? Area { get; set; }

    public string? Emirate { get; set; }

    public string ReportNumber { get; set; } = null!;

    public int Reportid { get; set; }

    public DateTime? ReportDate { get; set; }

    public int ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public bool? IsUploaded { get; set; }

    public string? IncidentDescription { get; set; }
}
