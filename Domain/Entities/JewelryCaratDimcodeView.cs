using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryCaratDimcodeView
{
    public string? JewelryCaratDescription { get; set; }

    public string? JewelryCaratCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
