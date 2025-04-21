using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentSettlement
{
    public int Id { get; set; }

    public DateTime? Settlementdate { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? TotalCount { get; set; }

    public int? PaymentMethod { get; set; }

    public int? IntegrationStatus { get; set; }

    public double? TotalReversedAmount { get; set; }

    public double? PayProAmount { get; set; }

    public int? PayProCount { get; set; }

    public double? PayProReversedAmount { get; set; }

    public int? PayProIntegrationResult { get; set; }

    public int? MerchantId { get; set; }

    public virtual ICollection<PaymentSettlementTransaction> PaymentSettlementTransactions { get; set; } = new List<PaymentSettlementTransaction>();
}
