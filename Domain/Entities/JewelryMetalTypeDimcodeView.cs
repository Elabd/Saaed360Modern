using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryMetalTypeDimcodeView
{
    public string? JewelryMetalTypeDescription { get; set; }

    public string? JewelryMetalTypeCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
