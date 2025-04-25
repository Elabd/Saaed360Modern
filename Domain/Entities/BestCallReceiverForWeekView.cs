using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BestCallReceiverForWeekView
{
    public long CallReceiverId { get; set; }

    public string CallReceiverCode { get; set; } = null!;

    public string CallReceiver { get; set; } = null!;

    public int? NoOfIncidents { get; set; }

    public TimeOnly? AverageResponeseTime { get; set; }

    public string? ControlCenter { get; set; }

    public byte[]? Image { get; set; }
}
