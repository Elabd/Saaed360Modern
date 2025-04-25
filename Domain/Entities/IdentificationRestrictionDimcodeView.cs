using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentificationRestrictionDimcodeView
{
    public string? IdentificationRestrictionDescription { get; set; }

    public string? IdentificationRestrictionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
