using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentFactorDimcodeView
{
    public string? IncidentFactorDescription { get; set; }

    public string? IncidentFactorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
