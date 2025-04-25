using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WarrantCategoryDimcodeView
{
    public string? WarrantCategoryDescription { get; set; }

    public string? WarrantCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
