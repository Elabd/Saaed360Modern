using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArrestCategoryDimcodeView
{
    public string? ArrestCategoryDescription { get; set; }

    public string? ArrestCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
