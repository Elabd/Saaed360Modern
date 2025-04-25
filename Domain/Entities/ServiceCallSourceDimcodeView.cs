using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallSourceDimcodeView
{
    public string? ServiceCallSourceDescription { get; set; }

    public string? ServiceCallSourceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

