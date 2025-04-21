using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewUpdateIncidentList
{
    public string MapIconStatus { get; set; } = null!;

    public long IncidentId { get; set; }

    public int IncidentStatusId { get; set; }

    public string? IncidentStatusCode { get; set; }

    public string? PatrolStatus { get; set; }

    public long? PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public string? PatrolSector { get; set; }

    public string? SupportStatus { get; set; }

    public bool? Isconverted { get; set; }

    public bool? Isdelivered { get; set; }
}
