using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationCategoryDimcodeView
{
    public string? LocationCategoryDescription { get; set; }

    public string? LocationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
