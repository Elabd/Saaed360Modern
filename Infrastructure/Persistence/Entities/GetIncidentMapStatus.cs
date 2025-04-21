using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetIncidentMapStatus
{
    public string MapIconStatus { get; set; } = null!;

    public long IncidentId { get; set; }

    public string? PatrolStatus { get; set; }

    public long? PatrolId { get; set; }

    public string? SupportStatus { get; set; }

    public Guid? IconId { get; set; }

    public bool? Isdelivered { get; set; }
}
