using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProviderStatusDimcodeView
{
    public string? ProviderStatusDescription { get; set; }

    public string? ProviderStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
