using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SourceDirectoryCategoryDimcodeView
{
    public string? SourceDirectoryCategoryDescription { get; set; }

    public string? SourceDirectoryCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
