using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchCompareDimcodeView
{
    public string? SearchCompareDescription { get; set; }

    public string? SearchCompareCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
