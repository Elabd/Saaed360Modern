using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityFacilityContainerGuidView
{
    public Guid ActivityOrganizationGuid { get; set; }

    public string ActivityOrganizationDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid OrganizationGuid { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
