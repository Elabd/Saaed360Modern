using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AverageReconstructionTimePerMonth
{
    public string? Month { get; set; }

    public int? AverageReconstructionTime { get; set; }
}
