using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OpenIncidentPerTypeView
{
    public int? Incidents { get; set; }

    public string? IncidentType { get; set; }
}
