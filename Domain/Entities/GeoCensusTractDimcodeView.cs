using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoCensusTractDimcodeView
{
    public string GeoCensusTractDescription { get; set; } = null!;

    public string GeoCensusTractCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
