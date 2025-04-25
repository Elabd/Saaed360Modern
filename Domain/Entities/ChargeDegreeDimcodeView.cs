using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeDegreeDimcodeView
{
    public string? ChargeDegreeDescription { get; set; }

    public string? ChargeDegreeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
