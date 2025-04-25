using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothingStyleDimcodeView
{
    public string? PersonClothingStyleDescription { get; set; }

    public string? PersonClothingStyleCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
