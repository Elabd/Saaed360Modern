using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MilitaryStatusDimcodeView
{
    public string? MilitaryStatusDescription { get; set; }

    public string? MilitaryStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
