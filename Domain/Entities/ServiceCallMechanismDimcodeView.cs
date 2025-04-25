using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallMechanismDimcodeView
{
    public string? ServiceCallMechanismDescription { get; set; }

    public string? ServiceCallMechanismCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

