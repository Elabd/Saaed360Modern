using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CitationStatusDimcodeView
{
    public string? CitationStatusDescription { get; set; }

    public string? CitationStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
