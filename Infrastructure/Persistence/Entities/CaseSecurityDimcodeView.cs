using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseSecurityDimcodeView
{
    public string? CaseSecurityDescription { get; set; }

    public string? CaseSecurityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
