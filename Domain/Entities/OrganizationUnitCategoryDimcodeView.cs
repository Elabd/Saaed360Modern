using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitCategoryDimcodeView
{
    public string? OrganizationUnitCategoryDescription { get; set; }

    public string? OrganizationUnitCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
