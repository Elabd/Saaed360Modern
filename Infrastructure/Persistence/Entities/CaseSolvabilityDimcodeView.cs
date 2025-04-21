using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseSolvabilityDimcodeView
{
    public string? CaseSolvabilityDescription { get; set; }

    public string? CaseSolvabilityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
