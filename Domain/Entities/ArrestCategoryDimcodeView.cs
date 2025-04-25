using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArrestCategoryDimcodeView
{
    public string? ArrestCategoryDescription { get; set; }

    public string? ArrestCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
