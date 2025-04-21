using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EnforcementOfficialCategoryDimcodeView
{
    public string? EnforcementOfficialCategoryDescription { get; set; }

    public string? EnforcementOfficialCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
