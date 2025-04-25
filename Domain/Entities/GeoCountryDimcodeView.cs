using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoCountryDimcodeView
{
    public string GeoCountryCode { get; set; } = null!;

    public string? GeoCountryCountryName { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
