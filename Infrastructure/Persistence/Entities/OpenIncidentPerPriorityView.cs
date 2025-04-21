using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OpenIncidentPerPriorityView
{
    public int? Incidents { get; set; }

    public string? Priority { get; set; }
}
