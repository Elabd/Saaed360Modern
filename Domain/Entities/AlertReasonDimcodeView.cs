using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertReasonDimcodeView
{
    public string? AlertReasonDescription { get; set; }

    public string? AlertReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
