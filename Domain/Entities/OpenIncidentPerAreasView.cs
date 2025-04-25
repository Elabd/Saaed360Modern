using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OpenIncidentPerAreasView
{
    public int? Incidents { get; set; }

    public string? Area { get; set; }
}
