using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonClothingCategoryDimcodeView
{
    public string? PersonClothingCategoryDescription { get; set; }

    public string? PersonClothingCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
