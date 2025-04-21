using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FacilityCategoryDimcodeView
{
    public string? FacilityCategoryDescription { get; set; }

    public string? FacilityCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
