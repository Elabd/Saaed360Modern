using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CitationDismissalConditionDimcodeView
{
    public string? CitationDismissalConditionDescription { get; set; }

    public string? CitationDismissalConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
