using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothingColorDimcodeView
{
    public string? PersonClothingColorDescription { get; set; }

    public string? PersonClothingColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
