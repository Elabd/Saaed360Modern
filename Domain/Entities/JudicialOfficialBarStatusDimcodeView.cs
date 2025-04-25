using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JudicialOfficialBarStatusDimcodeView
{
    public string? JudicialOfficialBarStatusDescription { get; set; }

    public string? JudicialOfficialBarStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
