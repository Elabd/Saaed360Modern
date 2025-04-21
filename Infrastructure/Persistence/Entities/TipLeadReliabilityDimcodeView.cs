using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLeadReliabilityDimcodeView
{
    public string? TipLeadReliabilityDescription { get; set; }

    public string? TipLeadReliabilityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
