using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MissingPersonCategoryDimcodeView
{
    public string? MissingPersonCategoryDescription { get; set; }

    public string? MissingPersonCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
