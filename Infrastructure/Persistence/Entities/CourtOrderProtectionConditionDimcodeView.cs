using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderProtectionConditionDimcodeView
{
    public string? CourtOrderProtectionConditionDescription { get; set; }

    public string? CourtOrderProtectionConditionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
