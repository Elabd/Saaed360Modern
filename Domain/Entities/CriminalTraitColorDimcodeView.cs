using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitColorDimcodeView
{
    public string? CriminalTraitColorDescription { get; set; }

    public string? CriminalTraitColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
