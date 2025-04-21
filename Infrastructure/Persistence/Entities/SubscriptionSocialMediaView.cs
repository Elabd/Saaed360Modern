using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionSocialMediaView
{
    public long SocialMediaId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? SocialMediaCategoryCode { get; set; }

    public string? SocialMediaCategoryDescription { get; set; }

    public string? Account { get; set; }

    public string Uri { get; set; } = null!;

    public string? Information { get; set; }

    public string? Title { get; set; }

    public string? RawData { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long SubscriptionSocialMediaId { get; set; }

    public string SubscriptionSocialMediaDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SocialMediaInvolvementDescription { get; set; }
}
