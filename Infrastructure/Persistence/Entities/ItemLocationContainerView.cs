using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemLocationContainerView
{
    public long ItemLocationId { get; set; }

    public string ItemLocationDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public long LocationId { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? LocationInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
