using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonClothingColorDimcodeView
{
    public string? PersonClothingColorDescription { get; set; }

    public string? PersonClothingColorCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
