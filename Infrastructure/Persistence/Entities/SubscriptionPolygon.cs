using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionPolygon
{
    public long SubscriptionPolygonId { get; set; }

    public Guid SubscriptionPolygonGuid { get; set; }

    public string SubscriptionPolygonDescription { get; set; } = null!;

    public long Subscriptionid { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int SubscriptionPolygonCategoryId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public long PolygonIdentifier { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;

    public virtual SubscriptionPolygonCategoryDim SubscriptionPolygonCategory { get; set; } = null!;
}
