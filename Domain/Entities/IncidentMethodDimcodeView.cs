using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentMethodDimcodeView
{
    public string? IncidentMethodDescription { get; set; }

    public string? IncidentMethodCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
