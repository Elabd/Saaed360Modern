using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoLeodimcodeView
{
    public string GeoLeocode { get; set; } = null!;

    public string? GeoLeodivision { get; set; }

    public string? GeoLeodistrict { get; set; }

    public string? GeoLeosector { get; set; }

    public string? GeoLeobeat { get; set; }

    public string? GeoLeodescription { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
