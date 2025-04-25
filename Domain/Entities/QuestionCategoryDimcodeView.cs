using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class QuestionCategoryDimcodeView
{
    public string? QuestionCategoryDescription { get; set; }

    public string? QuestionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
