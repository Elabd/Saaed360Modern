using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceCallSourceDimcodeView
{
    public string? ServiceCallSourceDescription { get; set; }

    public string? ServiceCallSourceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

