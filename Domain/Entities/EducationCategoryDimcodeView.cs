using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationCategoryDimcodeView
{
    public string EducationCategoryDescription { get; set; } = null!;

    public string EducationCategoryCode { get; set; } = null!;

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
