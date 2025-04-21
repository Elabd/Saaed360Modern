using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RegisterofActionCategoryDimcodeView
{
    public string? RegisterofActionCategoryDescription { get; set; }

    public string? RegisterofActionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
