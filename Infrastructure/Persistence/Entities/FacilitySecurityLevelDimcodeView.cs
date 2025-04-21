using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FacilitySecurityLevelDimcodeView
{
    public string? FacilitySecurityLevelDescription { get; set; }

    public string? FacilitySecurityLevelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
