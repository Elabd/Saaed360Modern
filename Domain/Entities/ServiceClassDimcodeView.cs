using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ServiceClassDimcodeView
{
    public string? ServiceClassDescription { get; set; }

    public string? ServiceClassCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

