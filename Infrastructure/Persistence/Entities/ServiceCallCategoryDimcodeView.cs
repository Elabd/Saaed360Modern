using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceCallCategoryDimcodeView
{
    public string? ServiceCallCategoryDescription { get; set; }

    public string? ServiceCallCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

