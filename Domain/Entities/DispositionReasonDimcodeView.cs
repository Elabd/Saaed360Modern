using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DispositionReasonDimcodeView
{
    public string? DispositionReasonDescription { get; set; }

    public string? DispositionReasonCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
