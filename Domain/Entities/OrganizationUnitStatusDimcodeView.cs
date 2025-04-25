using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationUnitStatusDimcodeView
{
    public string? OrganizationUnitStatusDescription { get; set; }

    public string? OrganizationUnitStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
