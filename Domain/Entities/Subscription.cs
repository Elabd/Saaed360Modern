using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Subscription
{
    public long SubscriptionId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int SubscriptionCategoryId { get; set; }

    public string? OriginalIdent { get; set; }

    public long SourceId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<ActivitySubscription> ActivitySubscriptions { get; set; } = new List<ActivitySubscription>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual SubscriptionCategoryDim SubscriptionCategory { get; set; } = null!;

    public virtual ICollection<SubscriptionLocation> SubscriptionLocations { get; set; } = new List<SubscriptionLocation>();

    public virtual ICollection<SubscriptionPolygon> SubscriptionPolygons { get; set; } = new List<SubscriptionPolygon>();

    public virtual ICollection<SubscriptionSocialMedium> SubscriptionSocialMedia { get; set; } = new List<SubscriptionSocialMedium>();

    public virtual ICollection<SubscriptionSubdivision> SubscriptionSubdivisions { get; set; } = new List<SubscriptionSubdivision>();
}
