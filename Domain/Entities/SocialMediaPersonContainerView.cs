using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaPersonContainerView
{
    public long SocialMediaPersonId { get; set; }

    public string SocialMediaPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long SocialMediaId { get; set; }

    public string? SourceName { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
