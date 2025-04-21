using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FingerPrintPatternCategoryDimcodeView
{
    public string? FingerPrintPatternCategoryDescription { get; set; }

    public string? FingerPrintPatternCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

