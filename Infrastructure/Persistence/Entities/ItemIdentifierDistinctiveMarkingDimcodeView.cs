using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemIdentifierDistinctiveMarkingDimcodeView
{
    public string? ItemIdentifierDistinctiveMarkingDescription { get; set; }

    public string? ItemIdentifierDistinctiveMarkingCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
