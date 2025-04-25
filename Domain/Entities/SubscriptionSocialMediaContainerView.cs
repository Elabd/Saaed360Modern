using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionSocialMediaContainerView
{
    public long SubscriptionSocialMediaId { get; set; }

    public string SubscriptionSocialMediaDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public long SocialMediaId { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SocialMediaInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
