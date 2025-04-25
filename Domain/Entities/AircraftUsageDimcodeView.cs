using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AircraftUsageDimcodeView
{
    public string? AircraftUsageDescription { get; set; }

    public string? AircraftUsageCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
