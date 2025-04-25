using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class BondConditionDimcodeView
{
    public string? BondConditionDescription { get; set; }

    public string? BondConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
