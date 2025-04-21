using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MeasureUnitDimcodeView
{
    public string? MeasureUnitDescription { get; set; }

    public string? MeasureUnitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
