using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingCmvdimcodeView
{
    public string? DrivingCmvdescription { get; set; }

    public string? DrivingCmvcode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
