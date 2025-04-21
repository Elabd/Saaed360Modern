using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairQuoteItem
{
    public long Id { get; set; }

    public long RepairQuoteId { get; set; }

    public string Name { get; set; } = null!;

    public int ItemTypeId { get; set; }

    public int Quantity { get; set; }

    public decimal ItemPrice { get; set; }

    public virtual RepairQuoteItemTypeDim ItemType { get; set; } = null!;

    public virtual RepairQuote RepairQuote { get; set; } = null!;
}
