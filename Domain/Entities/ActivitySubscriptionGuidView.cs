using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivitySubscriptionGuidView
{
    public Guid SubscriptionGuid { get; set; }

    public string? SubscriptionCategoryCode { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid ActivitySubscriptionGuid { get; set; }

    public string ActivitySubscriptionDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? SubscriptionInvolvementCode { get; set; }
}
