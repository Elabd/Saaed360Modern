using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RealestateCategoryDimcodeView
{
    public string? RealestateCategoryDescription { get; set; }

    public string? RealestateCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
