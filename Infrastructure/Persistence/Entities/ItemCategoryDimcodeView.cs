using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemCategoryDimcodeView
{
    public string? ItemCategoryDescription { get; set; }

    public string? ItemCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
