using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VesselCategoryDimcodeView
{
    public string? VesselCategoryDescription { get; set; }

    public string? VesselCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
