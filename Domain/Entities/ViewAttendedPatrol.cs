using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewAttendedPatrol
{
    public long PatrolId { get; set; }

    public string? PatrolNumber { get; set; }

    public long SectorId { get; set; }

    public string? Sector { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }
}
