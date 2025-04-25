using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionSocialMediaContainerGuidView
{
    public Guid SubscriptionSocialMediaGuid { get; set; }

    public string SubscriptionSocialMediaDescription { get; set; } = null!;

    public Guid SubscriptionGuid { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
