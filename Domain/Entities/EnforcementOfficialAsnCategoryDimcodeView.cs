using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EnforcementOfficialAsnCategoryDimcodeView
{
    public string? EnforcementOfficialAsnCategoryDescription { get; set; }

    public string? EnforcementOfficialAsnCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
