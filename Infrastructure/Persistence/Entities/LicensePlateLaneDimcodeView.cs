using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateLaneDimcodeView
{
    public string? LicensePlateLaneDescription { get; set; }

    public string? LicensePlateLaneCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

