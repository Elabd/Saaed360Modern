using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtCategoryDimcodeView
{
    public string? CourtCategoryDescription { get; set; }

    public string? CourtCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
