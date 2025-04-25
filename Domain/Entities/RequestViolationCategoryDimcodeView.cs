using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestViolationCategoryDimcodeView
{
    public string? RequestViolationCategoryDescription { get; set; }

    public string? RequestViolationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
