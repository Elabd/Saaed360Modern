using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentSettlementTransaction
{
    public int Id { get; set; }

    public int? SettlementId { get; set; }

    public long? SaaedTransactionId { get; set; }

    public string? PayProPaymentReference { get; set; }

    public string? PayProRefundReference { get; set; }

    public string? PayProMerchantReference { get; set; }

    public DateTime? PayProCreationDate { get; set; }

    public int? PayProTransactionType { get; set; }

    public virtual PaymentTransaction? SaaedTransaction { get; set; }

    public virtual PaymentSettlement? Settlement { get; set; }
}
