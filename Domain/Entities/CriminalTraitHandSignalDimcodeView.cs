using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitHandSignalDimcodeView
{
    public string? CriminalTraitHandSignalDescription { get; set; }

    public string? CriminalTraitHandSignalCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
