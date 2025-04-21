using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DocketCategoryDimcodeView
{
    public string? DocketCategoryDescription { get; set; }

    public string? DocketCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
