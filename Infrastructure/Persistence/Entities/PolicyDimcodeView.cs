using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PolicyDimcodeView
{
    public string? PolicyDescription { get; set; }

    public string? PolicyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
