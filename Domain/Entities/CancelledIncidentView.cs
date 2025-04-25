using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CancelledIncidentView
{
    public long IncidentId { get; set; }

    public string? Description { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public string? Sector { get; set; }

    public long? SectorId { get; set; }

    public long EmaraId { get; set; }

    public long AreaId { get; set; }

    public long? LandmarkId { get; set; }

    public int StatusId { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public string CallerNumber { get; set; } = null!;

    public int? ServiceCallIncidentTypeId { get; set; }
}
