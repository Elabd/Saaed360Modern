using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationAssociationCategoryDimcodeView
{
    public string? OrganizationAssociationCategoryDescription { get; set; }

    public string? OrganizationAssociationCategoryCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
