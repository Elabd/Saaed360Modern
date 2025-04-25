using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityOrganizationContainerView
{
    public long ActivityOrganizationId { get; set; }

    public string ActivityOrganizationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long Organizationid { get; set; }

    public string? SourceName { get; set; }

    public string? OrganizationInvolvementCode { get; set; }

    public string? OrganizationInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
