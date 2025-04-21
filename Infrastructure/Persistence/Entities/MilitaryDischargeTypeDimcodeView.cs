using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MilitaryDischargeTypeDimcodeView
{
    public string? MilitaryDischargeTypeDescription { get; set; }

    public string? MilitaryDischargeTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
