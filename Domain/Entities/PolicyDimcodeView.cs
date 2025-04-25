using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PolicyDimcodeView
{
    public string? PolicyDescription { get; set; }

    public string? PolicyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
