using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemIdentifierView
{
    public long ItemIdentifierId { get; set; }

    public string ItemIdentifierDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? ItemIdentifierLocationCode { get; set; }

    public string? ItemIdentifierLocationDescription { get; set; }

    public string? ItemIdentifierDistinctiveMarkingCode { get; set; }

    public string? ItemIdentifierDistinctiveMarkingDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
