using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonItemContainerView
{
    public long PersonItemId { get; set; }

    public string PersonItemDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long ItemId { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? ItemInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
