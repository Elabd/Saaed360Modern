using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationAuthorityDimcodeView
{
    public string? ItemRegistrationAuthorityDescription { get; set; }

    public string? ItemRegistrationAuthorityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
