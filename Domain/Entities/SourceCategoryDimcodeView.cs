using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SourceCategoryDimcodeView
{
    public string? SourceCategoryDescription { get; set; }

    public string? SourceCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
