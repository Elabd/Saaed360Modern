using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationStreetCategoryDimcodeView
{
    public string? LocationStreetCategoryDescription { get; set; }

    public string? LocationStreetCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
