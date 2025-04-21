using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationContactContainerGuidView
{
    public Guid OrganizationContactGuid { get; set; }

    public string OrganizationContactDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public Guid ContactGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
