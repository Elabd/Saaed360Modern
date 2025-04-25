using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RegisterofActionCategoryDimcodeView
{
    public string? RegisterofActionCategoryDescription { get; set; }

    public string? RegisterofActionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
