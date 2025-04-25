using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CounselingCategoryDimcodeView
{
    public string? CounselingCategoryDescription { get; set; }

    public string? CounselingCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
