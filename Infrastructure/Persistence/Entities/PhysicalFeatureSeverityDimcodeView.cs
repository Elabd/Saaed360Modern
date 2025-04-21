using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PhysicalFeatureSeverityDimcodeView
{
    public string? PhysicalFeatureSeverityDescription { get; set; }

    public string? PhysicalFeatureSeverityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
