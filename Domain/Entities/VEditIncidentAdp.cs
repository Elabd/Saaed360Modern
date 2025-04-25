using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VEditIncidentAdp
{
    public DateTime? IncidentDate { get; set; }

    public string? IncidentNumber { get; set; }

    public string CallerNumber { get; set; } = null!;

    public string CallerName { get; set; } = null!;

    public DateTime? AdpDate { get; set; }

    public string? AdpNumber { get; set; }

    public long SourceDetailId { get; set; }
}
