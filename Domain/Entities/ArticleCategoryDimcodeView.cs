using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArticleCategoryDimcodeView
{
    public string? ArticleCategoryDescription { get; set; }

    public string? ArticleCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
