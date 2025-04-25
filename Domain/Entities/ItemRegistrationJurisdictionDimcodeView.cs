using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationJurisdictionDimcodeView
{
    public string? ItemRegistrationJurisdictionDescription { get; set; }

    public string? ItemRegistrationJurisdictionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
