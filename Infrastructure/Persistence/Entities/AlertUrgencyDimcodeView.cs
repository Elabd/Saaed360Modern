using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AlertUrgencyDimcodeView
{
    public string? AlertUrgencyDescription { get; set; }

    public string? AlertUrgencyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
