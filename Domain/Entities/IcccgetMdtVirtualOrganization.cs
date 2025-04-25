using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccgetMdtVirtualOrganization
{
    public string? Code { get; set; }

    public long OrganizationId { get; set; }

    public long PersonId { get; set; }
}
