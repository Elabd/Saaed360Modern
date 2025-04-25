using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseRestrictionDimcodeView
{
    public string? CaseRestrictionDescription { get; set; }

    public string? CaseRestrictionCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
