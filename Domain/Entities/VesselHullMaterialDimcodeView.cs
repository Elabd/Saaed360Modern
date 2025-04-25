using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VesselHullMaterialDimcodeView
{
    public string? VesselHullMaterialDescription { get; set; }

    public string? VesselHullMaterialCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
