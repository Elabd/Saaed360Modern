using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BestDispatcherForWeekView
{
    public string CallDispatcher { get; set; } = null!;

    public string? DispatcherCode { get; set; }

    public long? DispatcherId { get; set; }

    public int? NoOfIncidents { get; set; }

    public TimeOnly? AverageResponeseTime { get; set; }

    public string? ControlCenter { get; set; }

    public byte[]? Image { get; set; }
}
