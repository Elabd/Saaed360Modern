using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaInvolvementDimcodeView
{
    public string? AreaInvolvementDescription { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
