using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BestCallReceiverForYearView
{
    public long CallReceiverId { get; set; }

    public string CallReceiverCode { get; set; } = null!;

    public string CallReceiver { get; set; } = null!;

    public int? NoOfIncidents { get; set; }

    public TimeOnly? AverageResponeseTime { get; set; }

    public string? ControlCenter { get; set; }

    public byte[]? Image { get; set; }
}
