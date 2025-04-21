using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReleaseAuthorizationCategoryDimcodeView
{
    public string? ReleaseAuthorizationCategoryDescription { get; set; }

    public string? ReleaseAuthorizationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
