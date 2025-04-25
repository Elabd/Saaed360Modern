using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ResponseReConstructionPerHour
{
    public int? AverageResponseTime { get; set; }

    public int? AverageReconstructionTime { get; set; }

    public int Hour { get; set; }
}
