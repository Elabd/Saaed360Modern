using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionGuidView
{
    public Guid SubscriptionGuid { get; set; }

    public string? SubscriptionCategoryCode { get; set; }

    public string? OriginalIdent { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
