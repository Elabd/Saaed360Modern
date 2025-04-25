using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityItemContainerView
{
    public long ActivityItemId { get; set; }

    public string ActivityItemDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public string? SourceName { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? ItemInvolvementDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
