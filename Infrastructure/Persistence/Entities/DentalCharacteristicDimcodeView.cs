using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DentalCharacteristicDimcodeView
{
    public string? DentalCharacteristicDescription { get; set; }

    public string? DentalCharacteristicCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
