using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VSaaedTsgetCanceledIncident
{
    public long IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public int IncidentPriorityId { get; set; }

    public string? IncidentPriority { get; set; }

    public int? IncidentTypeId { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public string? IncidentDescription { get; set; }

    public DateTime? IncidentDate { get; set; }

    public string? Emirate { get; set; }

    public long AreaId { get; set; }

    public long EmirateId { get; set; }

    public string? Area { get; set; }

    public string? CallerName { get; set; }

    public string CallerNumber { get; set; } = null!;

    public string CallerTakerName { get; set; } = null!;

    public long CallTakerId { get; set; }

    public long ControlCenterId { get; set; }

    public string? ControlCenterName { get; set; }

    public string? Address { get; set; }

    public string? SourceName { get; set; }

    public string? IncidentType { get; set; }

    public string? CancelationReason { get; set; }
}
