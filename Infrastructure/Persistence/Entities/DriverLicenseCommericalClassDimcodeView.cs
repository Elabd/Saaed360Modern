using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DriverLicenseCommericalClassDimcodeView
{
    public string? DriverLicenseCommericalClassDescription { get; set; }

    public string? DriverLicenseCommericalClassCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

