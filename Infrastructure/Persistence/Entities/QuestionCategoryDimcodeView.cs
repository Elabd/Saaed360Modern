using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class QuestionCategoryDimcodeView
{
    public string? QuestionCategoryDescription { get; set; }

    public string? QuestionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
