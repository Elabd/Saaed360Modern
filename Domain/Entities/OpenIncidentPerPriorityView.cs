using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OpenIncidentPerPriorityView
{
    public int? Incidents { get; set; }

    public string? Priority { get; set; }
}
