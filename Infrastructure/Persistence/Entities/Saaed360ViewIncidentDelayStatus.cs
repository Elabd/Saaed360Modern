using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Saaed360ViewIncidentDelayStatus
{
    public long ActivityId { get; set; }

    public string? StatusCode { get; set; }

    public int Delayed { get; set; }
}
