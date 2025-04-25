using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MeasureUnitDimcodeView
{
    public string? MeasureUnitDescription { get; set; }

    public string? MeasureUnitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
