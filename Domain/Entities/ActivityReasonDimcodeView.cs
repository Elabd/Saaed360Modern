using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityReasonDimcodeView
{
    public string? ActivityReasonDescription { get; set; }

    public string? ActivityReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
