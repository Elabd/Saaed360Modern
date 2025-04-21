using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AreaCategoryDimcodeView
{
    public string? AreaCategoryDescription { get; set; }

    public string? AreaCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
