using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentIntegrationLog
{
    public long IntegerationLogId { get; set; }

    public long? PaymentTransactionId { get; set; }

    public int? IntegrationMethodId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? RequestTime { get; set; }

    public DateTime? ResponseTime { get; set; }

    public virtual PaymentIntegrationMethod? IntegrationMethod { get; set; }

    public virtual PaymentTransaction? PaymentTransaction { get; set; }
}
