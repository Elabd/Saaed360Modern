using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentLevelDimcodeView
{
    public string? IncidentLevelDescription { get; set; }

    public string? IncidentLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
