using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArticleTypeDimcodeView
{
    public string? ArticleTypeDescription { get; set; }

    public string? ArticleTypeCode { get; set; }

    public string? ArticleTypeCategoryDescription { get; set; }

    public string? ArticleTypeCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
