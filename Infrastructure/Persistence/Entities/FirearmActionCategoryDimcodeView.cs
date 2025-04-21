using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FirearmActionCategoryDimcodeView
{
    public string? FirearmActionCategoryDescription { get; set; }

    public string? FirearmActionCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
