using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseStatusDimcodeView
{
    public string? CaseStatusDescription { get; set; }

    public string? CaseStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
