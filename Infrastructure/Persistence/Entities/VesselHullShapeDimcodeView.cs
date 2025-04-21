using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VesselHullShapeDimcodeView
{
    public string? VesselHullShapeDescription { get; set; }

    public string? VesselHullShapeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
