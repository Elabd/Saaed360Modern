using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairQuote
{
    public long Id { get; set; }

    public long RepairRequestGarageId { get; set; }

    public string? RepairDetails { get; set; }

    public long? InvoiceId { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public DateTime ExpectedCompleteDate { get; set; }

    public virtual Person? LastModifiedByNavigation { get; set; }

    public virtual ICollection<RepairImage> RepairImages { get; set; } = new List<RepairImage>();

    public virtual RepairInvoice? RepairInvoice { get; set; }

    public virtual ICollection<RepairQuoteItem> RepairQuoteItems { get; set; } = new List<RepairQuoteItem>();

    public virtual RepairRequestGarage RepairRequestGarage { get; set; } = null!;
}
