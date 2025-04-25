using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaLocationContainerView
{
    public long SocialMediaLocationId { get; set; }

    public string SocialMediaLocationDescription { get; set; } = null!;

    public long SocialMediaId { get; set; }

    public long LocationId { get; set; }

    public string? SourceName { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? LocationInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
