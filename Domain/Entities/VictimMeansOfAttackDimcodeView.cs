using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VictimMeansOfAttackDimcodeView
{
    public string? VictimMeansOfAttackDescription { get; set; }

    public string? VictimMeansOfAttackCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
