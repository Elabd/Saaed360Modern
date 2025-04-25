using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadCategoryDimcodeView
{
    public string? TipLeadCategoryDescription { get; set; }

    public string? TipLeadCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
