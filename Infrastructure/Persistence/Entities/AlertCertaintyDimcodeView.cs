using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AlertCertaintyDimcodeView
{
    public string? AlertCertaintyDescription { get; set; }

    public string? AlertCertaintyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
