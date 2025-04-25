using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestOffenseCategoryDimcodeView
{
    public string? RequestOffenseCategoryDescription { get; set; }

    public string? RequestOffenseCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
