using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PhysicalFeatureHandicapDimcodeView
{
    public string? PhysicalFeatureHandicapDescription { get; set; }

    public string? PhysicalFeatureHandicapCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
