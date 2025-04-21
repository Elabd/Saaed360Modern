using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentForceLevelDimcodeView
{
    public string? IncidentForceLevelDescription { get; set; }

    public string? IncidentForceLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
