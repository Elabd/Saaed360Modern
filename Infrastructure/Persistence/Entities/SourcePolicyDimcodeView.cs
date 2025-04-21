using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SourcePolicyDimcodeView
{
    public string? SourcePolicyDescription { get; set; }

    public string? SourcePolicyCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
