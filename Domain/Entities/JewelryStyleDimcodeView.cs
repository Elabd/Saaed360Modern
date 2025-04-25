using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStyleDimcodeView
{
    public string? JewelryStyleDescription { get; set; }

    public string? JewelryStyleCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
