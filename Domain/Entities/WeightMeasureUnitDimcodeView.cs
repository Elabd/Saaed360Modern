using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WeightMeasureUnitDimcodeView
{
    public string? WeightMeasureUnitDescription { get; set; }

    public string? WeightMeasureUnitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
