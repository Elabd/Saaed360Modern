using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrivingAccidentSeverityDimcodeView
{
    public string? DrivingAccidentSeverityDescription { get; set; }

    public string? DrivingAccidentSeverityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
