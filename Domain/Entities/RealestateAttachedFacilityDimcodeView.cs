using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RealestateAttachedFacilityDimcodeView
{
    public string? RealestateAttachedFacilityDescription { get; set; }

    public string? RealestateAttachedFacilityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
