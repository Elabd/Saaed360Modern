using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DriverLicensePermitStatusDimcodeView
{
    public string? DriverLicensePermitStatusDescription { get; set; }

    public string? DriverLicensePermitStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

