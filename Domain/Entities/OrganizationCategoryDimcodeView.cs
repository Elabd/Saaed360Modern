using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationCategoryDimcodeView
{
    public string? OrganizationCategoryDescription { get; set; }

    public string? OrganizationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
