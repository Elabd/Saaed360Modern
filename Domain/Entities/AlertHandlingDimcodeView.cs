using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertHandlingDimcodeView
{
    public string? AlertHandlingDescription { get; set; }

    public string? AlertHandlingCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
