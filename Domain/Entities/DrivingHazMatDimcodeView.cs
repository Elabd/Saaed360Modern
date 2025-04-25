using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingHazMatDimcodeView
{
    public string? DrivingHazMatDescription { get; set; }

    public string? DrivingHazMatCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
