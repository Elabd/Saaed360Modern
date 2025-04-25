using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingRoadConditionDimcodeView
{
    public string? DrivingRoadConditionDescription { get; set; }

    public string? DrivingRoadConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
