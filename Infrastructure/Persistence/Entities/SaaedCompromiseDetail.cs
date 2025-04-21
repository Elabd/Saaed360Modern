using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedCompromiseDetail
{
    public long CompromiseId { get; set; }

    public string? Comments { get; set; }

    public DateTime? CompromiseDate { get; set; }

    public string? CompromiseNumber { get; set; }

    public long? SourceId { get; set; }

    public string? Source { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public long? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string CallerName { get; set; } = null!;

    public string? CallerNumber { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }

    public long? EmaraId { get; set; }

    public string? Emara { get; set; }
}
