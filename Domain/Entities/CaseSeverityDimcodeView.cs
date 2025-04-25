using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseSeverityDimcodeView
{
    public string? CaseSeverityDescription { get; set; }

    public string? CaseSeverityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
