using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfficerInjuryListDimcodeView
{
    public string? OfficerInjuryListDescription { get; set; }

    public string? OfficerInjuryListCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
