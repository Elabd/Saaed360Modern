using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RealestateCategoryDimcodeView
{
    public string? RealestateCategoryDescription { get; set; }

    public string? RealestateCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
