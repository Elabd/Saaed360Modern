using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DentalToothPositionDimcodeView
{
    public string? DentalToothPositionDescription { get; set; }

    public string? DentalToothPositionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
