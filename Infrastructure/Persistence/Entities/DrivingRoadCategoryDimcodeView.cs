using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrivingRoadCategoryDimcodeView
{
    public string? DrivingRoadCategoryDescription { get; set; }

    public string? DrivingRoadCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
