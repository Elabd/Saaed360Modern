using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GeoCityDimcodeView
{
    public string GeoCityCode { get; set; } = null!;

    public string? GeoCityCityName { get; set; }

    public string? GeoCityStateName { get; set; }

    public string? GeoCityCountyName { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
