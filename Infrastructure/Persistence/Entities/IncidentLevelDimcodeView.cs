using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentLevelDimcodeView
{
    public string? IncidentLevelDescription { get; set; }

    public string? IncidentLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
