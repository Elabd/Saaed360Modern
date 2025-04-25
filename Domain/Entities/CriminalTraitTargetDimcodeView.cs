using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CriminalTraitTargetDimcodeView
{
    public string? CriminalTraitTargetDescription { get; set; }

    public string? CriminalTraitTargetCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
