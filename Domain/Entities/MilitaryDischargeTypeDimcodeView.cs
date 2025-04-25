using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MilitaryDischargeTypeDimcodeView
{
    public string? MilitaryDischargeTypeDescription { get; set; }

    public string? MilitaryDischargeTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
