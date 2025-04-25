using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PhysicalFeatureLocationDimcodeView
{
    public string? PhysicalFeatureLocationDescription { get; set; }

    public string? PhysicalFeatureLocationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
