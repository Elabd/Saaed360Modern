using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BestTrafficExpertForYearView
{
    public long? TrafficExpertId { get; set; }

    public string? TrafficExpertCode { get; set; }

    public string TrafficExpert { get; set; } = null!;

    public int? NoOfIncidents { get; set; }

    public TimeOnly? AverageReconstructionTime { get; set; }

    public string? ControlCenter { get; set; }

    public byte[]? Image { get; set; }
}
