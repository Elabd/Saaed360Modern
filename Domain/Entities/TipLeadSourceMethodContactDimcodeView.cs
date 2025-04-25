using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadSourceMethodContactDimcodeView
{
    public string? TipLeadSourceMethodContactDescription { get; set; }

    public string? TipLeadSourceMethodContactCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
