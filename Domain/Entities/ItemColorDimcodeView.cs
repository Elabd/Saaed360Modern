using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemColorDimcodeView
{
    public string? ItemColorDescription { get; set; }

    public string? ItemColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
