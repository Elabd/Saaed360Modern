using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivitySubscriptionView
{
    public long SubscriptionId { get; set; }

    public string? SubscriptionCategoryCode { get; set; }

    public string? SubscriptionCategoryDescription { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long ActivitySubscriptionId { get; set; }

    public string ActivitySubscriptionDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? SubscriptionInvolvementCode { get; set; }

    public string? SubscriptionInvolvementDescription { get; set; }
}
