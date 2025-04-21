using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RequestCheckCategoryDimcodeView
{
    public string? RequestCheckCategoryDescription { get; set; }

    public string? RequestCheckCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
