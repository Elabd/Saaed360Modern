using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestCategoryDimcodeView
{
    public string? RequestCategoryDescription { get; set; }

    public string RequestCategoryCode { get; set; } = null!;

    public string? RequestCategoryCategorySubDescription { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
