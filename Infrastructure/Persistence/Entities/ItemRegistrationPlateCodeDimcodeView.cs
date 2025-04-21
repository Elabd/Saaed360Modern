using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationPlateCodeDimcodeView
{
    public string? ItemRegistrationPlateCodeDescription { get; set; }

    public string? ItemRegistrationPlateCodeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

