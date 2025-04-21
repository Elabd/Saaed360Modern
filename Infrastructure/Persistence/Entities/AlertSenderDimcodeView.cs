using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AlertSenderDimcodeView
{
    public string? AlertSenderDescription { get; set; }

    public string? AlertSenderCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
