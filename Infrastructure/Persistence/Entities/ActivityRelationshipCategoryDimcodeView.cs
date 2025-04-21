using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityRelationshipCategoryDimcodeView
{
    public string? ActivityRelationshipCategoryDescription { get; set; }

    public string? ActivityRelationshipCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
