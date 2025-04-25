using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class HighLowDimcodeView
{
    public string? HighLowDescription { get; set; }

    public string? HighLowCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
