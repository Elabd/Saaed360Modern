using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationPlateKindDimcodeView
{
    public string? ItemRegistrationPlateKindDescription { get; set; }

    public string? ItemRegistrationPlateKindCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

