using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemIdentifierLocationDimcodeView
{
    public string? ItemIdentifierLocationDescription { get; set; }

    public string? ItemIdentifierLocationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
