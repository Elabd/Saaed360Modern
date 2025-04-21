using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionSocialMedium
{
    public long SubscriptionSocialMediaId { get; set; }

    public Guid SubscriptionSocialMediaGuid { get; set; }

    public string SubscriptionSocialMediaDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public int SocialMediaInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual SocialMediaInvolvementDim SocialMediaInvolvement { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;
}
