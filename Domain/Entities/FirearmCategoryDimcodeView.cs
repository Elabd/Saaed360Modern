using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FirearmCategoryDimcodeView
{
    public string? FirearmCategoryDescription { get; set; }

    public string? FirearmCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
