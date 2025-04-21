using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportPaymentTransaction
{
    public long ReportPaymentTransactionId { get; set; }

    public int ReportId { get; set; }

    public int EvgPaymentStatusId { get; set; }

    public long AdpreportNumber { get; set; }

    public long? ReceiptNumber { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? PaymentDate { get; set; }

    public virtual EvgPaymentStatusDim EvgPaymentStatus { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual ICollection<ReportPaymentTransactionLog> ReportPaymentTransactionLogs { get; set; } = new List<ReportPaymentTransactionLog>();
}
