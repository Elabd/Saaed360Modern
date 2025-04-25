using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MultiSourceOffenderDimcodeView
{
    public string? MultiSourceOffenderDescription { get; set; }

    public string? MultiSourceOffenderCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
