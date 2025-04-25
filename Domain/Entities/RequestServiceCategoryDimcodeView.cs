using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestServiceCategoryDimcodeView
{
    public string? RequestServiceCategoryDescription { get; set; }

    public string? RequestServiceCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

