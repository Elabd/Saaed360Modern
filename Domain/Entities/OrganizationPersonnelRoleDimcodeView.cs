using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationPersonnelRoleDimcodeView
{
    public string? OrganizationPersonnelRoleDescription { get; set; }

    public string? OrganizationPersonnelRoleCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
