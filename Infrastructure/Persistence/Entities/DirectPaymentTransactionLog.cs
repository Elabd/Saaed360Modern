using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DirectPaymentTransactionLog
{
    public long Id { get; set; }

    public long? DirectPaymentTransactionId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? DirectPaymentStatusId { get; set; }

    public string? Message { get; set; }
}
