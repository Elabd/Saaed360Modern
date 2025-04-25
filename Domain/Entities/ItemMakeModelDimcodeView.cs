using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemMakeModelDimcodeView
{
    public string ItemMakeModelCode { get; set; } = null!;

    public string? ItemMakeModelMake { get; set; }

    public string? ItemMakeModelModel { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
