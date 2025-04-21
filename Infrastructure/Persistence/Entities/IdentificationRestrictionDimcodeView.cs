using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentificationRestrictionDimcodeView
{
    public string? IdentificationRestrictionDescription { get; set; }

    public string? IdentificationRestrictionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
