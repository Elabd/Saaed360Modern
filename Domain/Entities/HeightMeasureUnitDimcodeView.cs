using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class HeightMeasureUnitDimcodeView
{
    public string? HeightMeasureUnitDescription { get; set; }

    public string? HeightMeasureUnitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
