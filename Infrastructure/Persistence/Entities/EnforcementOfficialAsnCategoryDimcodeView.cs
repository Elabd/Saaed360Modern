using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EnforcementOfficialAsnCategoryDimcodeView
{
    public string? EnforcementOfficialAsnCategoryDescription { get; set; }

    public string? EnforcementOfficialAsnCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
