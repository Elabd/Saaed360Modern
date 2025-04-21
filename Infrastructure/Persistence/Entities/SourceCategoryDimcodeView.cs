using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SourceCategoryDimcodeView
{
    public string? SourceCategoryDescription { get; set; }

    public string? SourceCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
