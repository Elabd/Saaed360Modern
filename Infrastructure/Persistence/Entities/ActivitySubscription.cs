using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivitySubscription
{
    public long ActivitySubscriptionId { get; set; }

    public Guid ActivitySubscriptionGuid { get; set; }

    public string ActivitySubscriptionDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SubscriptionId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public long SourceId { get; set; }

    public int SubscriptionInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;

    public virtual SubscriptionInvolvementDim SubscriptionInvolvement { get; set; } = null!;
}
