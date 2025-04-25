using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FingerprintFingerDimcodeView
{
    public string? FingerprintFingerDescription { get; set; }

    public string? FingerprintFingerCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

