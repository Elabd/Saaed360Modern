using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TipLeadSourceMethodContactDimcodeView
{
    public string? TipLeadSourceMethodContactDescription { get; set; }

    public string? TipLeadSourceMethodContactCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
