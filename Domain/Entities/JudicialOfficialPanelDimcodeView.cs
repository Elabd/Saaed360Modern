using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JudicialOfficialPanelDimcodeView
{
    public string? JudicialOfficialPanelDescription { get; set; }

    public string? JudicialOfficialPanelCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
