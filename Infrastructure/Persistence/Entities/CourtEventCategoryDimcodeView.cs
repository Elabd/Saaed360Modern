using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtEventCategoryDimcodeView
{
    public string? CourtEventCategoryDescription { get; set; }

    public string? CourtEventCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
