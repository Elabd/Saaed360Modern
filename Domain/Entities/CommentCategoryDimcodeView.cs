using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommentCategoryDimcodeView
{
    public string? CommentCategoryDescription { get; set; }

    public string? CommentCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
