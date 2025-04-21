using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OpenIncidentPerAreasView
{
    public int? Incidents { get; set; }

    public string? Area { get; set; }
}
