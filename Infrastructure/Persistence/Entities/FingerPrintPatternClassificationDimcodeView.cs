using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FingerPrintPatternClassificationDimcodeView
{
    public string? FingerPrintPatternClassificationDescription { get; set; }

    public string? FingerPrintPatternClassificationCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

