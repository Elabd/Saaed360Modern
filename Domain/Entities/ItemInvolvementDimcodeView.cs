using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemInvolvementDimcodeView
{
    public string? ItemInvolvementDescription { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
