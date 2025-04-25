using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemStatusDimcodeView
{
    public string? ItemStatusDescription { get; set; }

    public string? ItemStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
