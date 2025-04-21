using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DelayedOpenedIncidentsByStatusView
{
    public int? Count { get; set; }

    public string Status { get; set; } = null!;
}
