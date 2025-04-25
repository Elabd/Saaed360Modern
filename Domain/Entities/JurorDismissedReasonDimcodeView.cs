using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JurorDismissedReasonDimcodeView
{
    public string? JurorDismissedReasonDescription { get; set; }

    public string? JurorDismissedReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
