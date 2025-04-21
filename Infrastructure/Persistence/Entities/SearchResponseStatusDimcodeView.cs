using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SearchResponseStatusDimcodeView
{
    public string? SearchResponseStatusDescription { get; set; }

    public string? SearchResponseStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
