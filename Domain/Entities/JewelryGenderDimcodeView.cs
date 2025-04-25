using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryGenderDimcodeView
{
    public string? JewelryGenderDescription { get; set; }

    public string? JewelryGenderCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
