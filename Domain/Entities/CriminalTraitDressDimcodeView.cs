using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitDressDimcodeView
{
    public string? CriminalTraitDressDescription { get; set; }

    public string? CriminalTraitDressCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
