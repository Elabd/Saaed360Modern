using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseExhibitStatusDimcodeView
{
    public string? CaseExhibitStatusDescription { get; set; }

    public string? CaseExhibitStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
