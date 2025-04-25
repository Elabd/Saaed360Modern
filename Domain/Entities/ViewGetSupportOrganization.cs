using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewGetSupportOrganization
{
    public long ActivityItemId { get; set; }

    public long ItemId { get; set; }

    public string? SerialIdentification { get; set; }

    public long OrganizationId { get; set; }

    public string? Name { get; set; }
}
