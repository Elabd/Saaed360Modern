using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeStatusDimcodeView
{
    public string? ChargeStatusDescription { get; set; }

    public string? ChargeStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
