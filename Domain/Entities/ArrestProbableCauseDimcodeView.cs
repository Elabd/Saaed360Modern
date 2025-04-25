using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArrestProbableCauseDimcodeView
{
    public string? ArrestProbableCauseDescription { get; set; }

    public string? ArrestProbableCauseCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
