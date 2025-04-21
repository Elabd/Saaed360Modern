using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CourtOrderCategoryDimcodeView
{
    public string? CourtOrderCategoryDescription { get; set; }

    public string? CourtOrderCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
