using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VesselPropulsionTypeDimcodeView
{
    public string? VesselPropulsionTypeDescription { get; set; }

    public string? VesselPropulsionTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
