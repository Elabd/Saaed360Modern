using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationInvolvementDimcodeView
{
    public string? OrganizationInvolvementDescription { get; set; }

    public string? OrganizationInvolvementCode { get; set; }

    public bool? IsShown { get; set; }

    public string? RowStatusCode { get; set; }
}
