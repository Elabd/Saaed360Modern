using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStoneCutDimcodeView
{
    public string? JewelryStoneCutDescription { get; set; }

    public string? JewelryStoneCutCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
