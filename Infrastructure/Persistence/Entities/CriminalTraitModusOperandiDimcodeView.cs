using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CriminalTraitModusOperandiDimcodeView
{
    public string? CriminalTraitModusOperandiDescription { get; set; }

    public string? CriminalTraitModusOperandiCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
