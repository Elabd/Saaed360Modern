using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationContactContainerView
{
    public long OrganizationContactId { get; set; }

    public string OrganizationContactDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public long Contactid { get; set; }

    public long OrganizationId { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? ContactInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
