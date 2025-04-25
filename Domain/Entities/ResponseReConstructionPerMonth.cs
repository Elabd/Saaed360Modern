using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ResponseReConstructionPerMonth
{
    public int? AverageResponseTime { get; set; }

    public int? AverageReconstructionTime { get; set; }

    public string Month { get; set; } = null!;

    public int MonthNumber { get; set; }
}
