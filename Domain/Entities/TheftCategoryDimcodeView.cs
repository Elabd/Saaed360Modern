using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TheftCategoryDimcodeView
{
    public string? TheftCategoryDescription { get; set; }

    public string? TheftCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
