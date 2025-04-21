using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JewelryCategoryDimcodeView
{
    public string? JewelryCategoryDescription { get; set; }

    public string? JewelryCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
