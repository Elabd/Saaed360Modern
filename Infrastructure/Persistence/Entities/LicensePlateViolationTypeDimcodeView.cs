using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LicensePlateViolationTypeDimcodeView
{
    public string? LicensePlateViolationTypeDescription { get; set; }

    public string? LicensePlateViolationTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

