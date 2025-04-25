using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ProviderCategoryDimcodeView
{
    public string? ProviderCategoryDescription { get; set; }

    public string? ProviderCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
