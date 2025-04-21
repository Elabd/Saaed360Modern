using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AverageResponseTimeByMonth
{
    public string? Month { get; set; }

    public int? AverageResponseTime { get; set; }
}
