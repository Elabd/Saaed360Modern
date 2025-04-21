using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivitySubscriptionContainerView
{
    public long ActivitySubscriptionId { get; set; }

    public string ActivitySubscriptionDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long SubscriptionId { get; set; }

    public string? SourceName { get; set; }

    public string? SubscriptionInvolvementCode { get; set; }

    public string? SubscriptionInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
