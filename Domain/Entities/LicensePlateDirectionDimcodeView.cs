using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LicensePlateDirectionDimcodeView
{
    public string? LicensePlateDirectionDescription { get; set; }

    public string? LicensePlateDirectionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

