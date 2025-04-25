using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AverageResponseTimeByMonth
{
    public string? Month { get; set; }

    public int? AverageResponseTime { get; set; }
}
