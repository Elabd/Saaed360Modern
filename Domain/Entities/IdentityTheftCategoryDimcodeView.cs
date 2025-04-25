using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentityTheftCategoryDimcodeView
{
    public string? IdentityTheftCategoryDescription { get; set; }

    public string? IdentityTheftCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

