using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentRefundDetail
{
    public long PaymentRefundDetails { get; set; }

    public long PaymentTransactionId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? RefundDate { get; set; }

    public int? RefundStatusId { get; set; }

    public string? Comments { get; set; }

    public virtual PaymentTransaction PaymentTransaction { get; set; } = null!;

    public virtual PaymentRequestStatusDim? RefundStatus { get; set; }
}
