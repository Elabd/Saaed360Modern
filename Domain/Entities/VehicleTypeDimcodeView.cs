using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleTypeDimcodeView
{
    public string? VehicleTypeDescription { get; set; }

    public string? VehicleTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
