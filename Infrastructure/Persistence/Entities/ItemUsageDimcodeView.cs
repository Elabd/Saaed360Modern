using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemUsageDimcodeView
{
    public string? ItemUsageDescription { get; set; }

    public string? ItemUsageCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
