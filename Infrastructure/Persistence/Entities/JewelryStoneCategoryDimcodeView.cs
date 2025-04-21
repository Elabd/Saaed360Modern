using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JewelryStoneCategoryDimcodeView
{
    public string? JewelryStoneCategoryDescription { get; set; }

    public string? JewelryStoneCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
