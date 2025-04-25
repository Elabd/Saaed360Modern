using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityCategoryDimcodeView
{
    public string? ActivityCategoryDescription { get; set; }

    public string? ActivityCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
