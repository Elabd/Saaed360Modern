using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SearchCategoryDimcodeView
{
    public string? SearchCategoryDescription { get; set; }

    public string? SearchCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
