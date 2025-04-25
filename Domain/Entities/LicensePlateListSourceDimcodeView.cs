using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicensePlateListSourceDimcodeView
{
    public string? LicensePlateListSourceDescription { get; set; }

    public string? LicensePlateListSourceCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

