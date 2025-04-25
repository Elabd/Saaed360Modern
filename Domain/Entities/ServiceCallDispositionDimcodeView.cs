using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceCallDispositionDimcodeView
{
    public string? ServiceCallDispositionDescription { get; set; }

    public string? ServiceCallDispositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

