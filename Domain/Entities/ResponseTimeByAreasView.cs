using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ResponseTimeByAreasView
{
    public TimeOnly? AverageResponseTime { get; set; }

    public string? Area { get; set; }
}
