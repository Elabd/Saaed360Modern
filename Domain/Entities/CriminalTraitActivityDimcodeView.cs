using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitActivityDimcodeView
{
    public string? CriminalTraitActivityDescription { get; set; }

    public string? CriminalTraitActivityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
