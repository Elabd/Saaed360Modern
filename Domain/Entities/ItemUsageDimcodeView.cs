using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemUsageDimcodeView
{
    public string? ItemUsageDescription { get; set; }

    public string? ItemUsageCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
