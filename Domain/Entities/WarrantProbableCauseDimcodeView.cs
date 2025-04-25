using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WarrantProbableCauseDimcodeView
{
    public string? WarrantProbableCauseDescription { get; set; }

    public string? WarrantProbableCauseCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
