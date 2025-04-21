using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FirearmCategoryDimcodeView
{
    public string? FirearmCategoryDescription { get; set; }

    public string? FirearmCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
