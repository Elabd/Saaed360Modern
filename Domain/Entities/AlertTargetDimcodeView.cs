using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertTargetDimcodeView
{
    public string? AlertTargetDescription { get; set; }

    public string? AlertTargetCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
