using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertSeverityDimcodeView
{
    public string? AlertSeverityDescription { get; set; }

    public string? AlertSeverityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
