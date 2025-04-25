using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WarrantAppearanceBailForfeitDimcodeView
{
    public string? WarrantAppearanceBailForfeitDescription { get; set; }

    public string? WarrantAppearanceBailForfeitCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
