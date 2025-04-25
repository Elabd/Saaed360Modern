using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallPriorityDimcodeView
{
    public string? ServiceCallPriorityDescription { get; set; }

    public string? ServiceCallPriorityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

