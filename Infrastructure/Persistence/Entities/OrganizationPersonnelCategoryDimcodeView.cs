using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationPersonnelCategoryDimcodeView
{
    public string? OrganizationPersonnelCategoryDescription { get; set; }

    public string? OrganizationPersonnelCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
