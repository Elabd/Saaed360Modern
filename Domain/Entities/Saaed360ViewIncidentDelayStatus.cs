using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Saaed360ViewIncidentDelayStatus
{
    public long ActivityId { get; set; }

    public string? StatusCode { get; set; }

    public int Delayed { get; set; }
}
