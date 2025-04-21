using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationStatusDimcodeView
{
    public string? OrganizationStatusDescription { get; set; }

    public string? OrganizationStatusCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
