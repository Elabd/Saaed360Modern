using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemIdentifierLocationDimcodeView
{
    public string? ItemIdentifierLocationDescription { get; set; }

    public string? ItemIdentifierLocationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
