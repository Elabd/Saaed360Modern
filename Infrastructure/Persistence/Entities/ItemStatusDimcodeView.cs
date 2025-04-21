using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemStatusDimcodeView
{
    public string? ItemStatusDescription { get; set; }

    public string? ItemStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
