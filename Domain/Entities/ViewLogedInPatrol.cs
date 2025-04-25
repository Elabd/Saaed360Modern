using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewLogedInPatrol
{
    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public string TrafficExcert { get; set; } = null!;

    public string SectorCode { get; set; } = null!;
}
