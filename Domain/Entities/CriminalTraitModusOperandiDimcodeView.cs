using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitModusOperandiDimcodeView
{
    public string? CriminalTraitModusOperandiDescription { get; set; }

    public string? CriminalTraitModusOperandiCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
