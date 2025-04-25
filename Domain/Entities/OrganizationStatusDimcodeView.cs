using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationStatusDimcodeView
{
    public string? OrganizationStatusDescription { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
