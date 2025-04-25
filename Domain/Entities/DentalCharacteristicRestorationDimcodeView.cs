using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DentalCharacteristicRestorationDimcodeView
{
    public string? DentalCharacteristicRestorationDescription { get; set; }

    public string? DentalCharacteristicRestorationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
