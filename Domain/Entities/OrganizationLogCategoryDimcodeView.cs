using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationLogCategoryDimcodeView
{
    public string? OrganizationLogCategoryDescription { get; set; }

    public string? OrganizationLogCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
