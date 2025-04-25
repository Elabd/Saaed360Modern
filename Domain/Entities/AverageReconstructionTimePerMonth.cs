using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AverageReconstructionTimePerMonth
{
    public string? Month { get; set; }

    public int? AverageReconstructionTime { get; set; }
}
