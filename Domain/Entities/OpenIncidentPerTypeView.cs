using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OpenIncidentPerTypeView
{
    public int? Incidents { get; set; }

    public string? IncidentType { get; set; }
}
