using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DispositionCategoryDimcodeView
{
    public string? DispositionCategoryDescription { get; set; }

    public string? DispositionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
