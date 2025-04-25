using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TipLeadSourceCategoryDimcodeView
{
    public string? TipLeadSourceCategoryDescription { get; set; }

    public string? TipLeadSourceCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
