using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FacilityMemberCategoryDimcodeView
{
    public string? FacilityMemberCategoryDescription { get; set; }

    public string? FacilityMemberCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
