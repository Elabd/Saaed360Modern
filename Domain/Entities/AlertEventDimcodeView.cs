using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertEventDimcodeView
{
    public string? AlertEventDescription { get; set; }

    public string? AlertEventCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
