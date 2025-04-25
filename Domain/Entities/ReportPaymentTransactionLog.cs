using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportPaymentTransactionLog
{
    public long ReportPaymentTransactionLogId { get; set; }

    public long ReportPaymentTransactionId { get; set; }

    public long OrderId { get; set; }

    public int EvgPaymentStatusId { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual ReportPaymentTransaction ReportPaymentTransaction { get; set; } = null!;
}
