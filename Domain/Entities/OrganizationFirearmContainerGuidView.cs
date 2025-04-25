using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationFirearmContainerGuidView
{
    public Guid OrganizationItemGuid { get; set; }

    public string OrganizationItemDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid ItemGuid { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
