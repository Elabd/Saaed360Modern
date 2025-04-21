using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ResponseReConstructionPerHour
{
    public int? AverageResponseTime { get; set; }

    public int? AverageReconstructionTime { get; set; }

    public int Hour { get; set; }
}
