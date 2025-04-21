using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PhysicalFeatureCategoryDimcodeView
{
    public string? PhysicalFeatureCategoryDescription { get; set; }

    public string? PhysicalFeatureCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
