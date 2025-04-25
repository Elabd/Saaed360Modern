using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoLocationSubDivisionDimcodeView
{
    public string? GeoLocationSubDivisionState { get; set; }

    public string? GeoLocationSubDivisionCounty { get; set; }

    public string? GeoLocationSubDivisionCity { get; set; }

    public string? GeoLocationSubDivisionSubDivision { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
