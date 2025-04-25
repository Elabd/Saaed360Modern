using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DentalToothPositionDimcodeView
{
    public string? DentalToothPositionDescription { get; set; }

    public string? DentalToothPositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
