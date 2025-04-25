using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchResponseStatusDimcodeView
{
    public string? SearchResponseStatusDescription { get; set; }

    public string? SearchResponseStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
