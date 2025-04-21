using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArticleCategoryDimcodeView
{
    public string? ArticleCategoryDescription { get; set; }

    public string? ArticleCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
