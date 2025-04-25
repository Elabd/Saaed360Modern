using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseCategoryDimcodeView
{
    public string? CaseCategoryDescription { get; set; }

    public string? CaseCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
