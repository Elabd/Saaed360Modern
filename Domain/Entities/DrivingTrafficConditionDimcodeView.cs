using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingTrafficConditionDimcodeView
{
    public string? DrivingTrafficConditionDescription { get; set; }

    public string? DrivingTrafficConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
