using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DocketCategoryDimcodeView
{
    public string? DocketCategoryDescription { get; set; }

    public string? DocketCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
