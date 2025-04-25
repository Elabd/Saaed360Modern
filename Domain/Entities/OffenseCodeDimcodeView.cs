using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCodeDimcodeView
{
    public string? OffenseCodeDescription { get; set; }

    public string? OffenseCodeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
