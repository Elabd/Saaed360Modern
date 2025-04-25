using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FacilityMemberCategoryDimcodeView
{
    public string? FacilityMemberCategoryDescription { get; set; }

    public string? FacilityMemberCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
