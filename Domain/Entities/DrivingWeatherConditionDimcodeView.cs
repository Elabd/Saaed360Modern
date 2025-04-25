using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingWeatherConditionDimcodeView
{
    public string? DrivingWeatherConditionDescription { get; set; }

    public string? DrivingWeatherConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
