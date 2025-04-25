using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitDimcodeView
{
    public string? CriminalTraitDescription { get; set; }

    public string? CriminalTraitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
