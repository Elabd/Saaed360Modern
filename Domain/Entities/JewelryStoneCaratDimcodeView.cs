using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStoneCaratDimcodeView
{
    public string? JewelryStoneCaratDescription { get; set; }

    public string? JewelryStoneCaratCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
