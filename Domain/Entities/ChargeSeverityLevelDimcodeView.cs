using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeSeverityLevelDimcodeView
{
    public string? ChargeSeverityLevelDescription { get; set; }

    public string? ChargeSeverityLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
