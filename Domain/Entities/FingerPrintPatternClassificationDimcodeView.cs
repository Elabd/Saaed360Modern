using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FingerPrintPatternClassificationDimcodeView
{
    public string? FingerPrintPatternClassificationDescription { get; set; }

    public string? FingerPrintPatternClassificationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

