using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivitySocialMediaContainerView
{
    public long ActivitySocialMediaId { get; set; }

    public string ActivitySocialMediaDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SocialMediaInvolvementDescription { get; set; }

    public long ActivityId { get; set; }

    public long SocialMediaId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
