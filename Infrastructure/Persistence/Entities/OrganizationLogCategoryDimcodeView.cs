using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationLogCategoryDimcodeView
{
    public string? OrganizationLogCategoryDescription { get; set; }

    public string? OrganizationLogCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
