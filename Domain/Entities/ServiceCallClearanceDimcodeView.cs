using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallClearanceDimcodeView
{
    public string? ServiceCallClearanceDescription { get; set; }

    public string? ServiceCallClearanceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

