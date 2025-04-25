using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicensePlateListTypeDimcodeView
{
    public string? LicensePlateListTypeDescription { get; set; }

    public string? LicensePlateListTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

