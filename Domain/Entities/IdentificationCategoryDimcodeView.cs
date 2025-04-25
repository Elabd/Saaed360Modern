using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentificationCategoryDimcodeView
{
    public string? IdentificationCategoryDescription { get; set; }

    public string? IdentificationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
