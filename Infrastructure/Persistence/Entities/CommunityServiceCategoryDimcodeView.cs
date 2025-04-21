using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommunityServiceCategoryDimcodeView
{
    public string? CommunityServiceCategoryDescription { get; set; }

    public string? CommunityServiceCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}

