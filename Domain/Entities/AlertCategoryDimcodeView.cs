using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AlertCategoryDimcodeView
{
    public string? AlertCategoryDescription { get; set; }

    public string? AlertCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
