using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtActionCategoryDimcodeView
{
    public string? CourtActionCategoryDescription { get; set; }

    public string? CourtActionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
