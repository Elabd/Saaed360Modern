using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationLocationContainerGuidView
{
    public Guid OrganizationLocationGuid { get; set; }

    public string OrganizationLocationDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid LocationGuid { get; set; }

    public string? SourceName { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
