using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentChannelReturnPage
{
    public int Id { get; set; }

    public long? TransactionId { get; set; }

    public string? ReturnUrl { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual PaymentTransaction? Transaction { get; set; }
}
