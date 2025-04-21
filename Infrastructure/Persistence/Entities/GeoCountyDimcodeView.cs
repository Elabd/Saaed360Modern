using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GeoCountyDimcodeView
{
    public string GeoCountyCode { get; set; } = null!;

    public string? GeoCountyCountyName { get; set; }

    public string? GeoCountyStateName { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
