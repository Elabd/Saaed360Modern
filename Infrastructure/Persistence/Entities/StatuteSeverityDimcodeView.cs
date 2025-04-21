using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class StatuteSeverityDimcodeView
{
    public string? StatuteSeverityDescription { get; set; }

    public string? StatuteSeverityCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
