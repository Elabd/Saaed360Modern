using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonJewelryDimcodeView
{
    public string? PersonJewelryDescription { get; set; }

    public string? PersonJewelryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
