using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadContentValidityDimcodeView
{
    public string? TipLeadContentValidityDescription { get; set; }

    public string? TipLeadContentValidityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
