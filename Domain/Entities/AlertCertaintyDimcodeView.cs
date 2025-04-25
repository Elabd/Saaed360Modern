using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertCertaintyDimcodeView
{
    public string? AlertCertaintyDescription { get; set; }

    public string? AlertCertaintyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
