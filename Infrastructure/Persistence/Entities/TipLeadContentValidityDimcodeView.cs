using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLeadContentValidityDimcodeView
{
    public string? TipLeadContentValidityDescription { get; set; }

    public string? TipLeadContentValidityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
