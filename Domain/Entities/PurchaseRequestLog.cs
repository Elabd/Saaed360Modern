using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PurchaseRequestLog
{
    public long PurchaseRequestLogId { get; set; }

    public long PurchaseRequestId { get; set; }

    public int StatusId { get; set; }

    public long ModifiedBy { get; set; }

    public DateTime ModifiedDate { get; set; }

    public decimal? SubmittedOfferValue { get; set; }

    public decimal? BuyPrice { get; set; }

    public virtual Person ModifiedByNavigation { get; set; } = null!;

    public virtual PurchaseRequest PurchaseRequest { get; set; } = null!;

    public virtual PurchaseRequestStatus Status { get; set; } = null!;
}
