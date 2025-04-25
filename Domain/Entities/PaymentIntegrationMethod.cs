using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PaymentIntegrationMethod
{
    public int MethodId { get; set; }

    public string MethodName { get; set; } = null!;

    public virtual ICollection<PaymentIntegrationLog> PaymentIntegrationLogs { get; set; } = new List<PaymentIntegrationLog>();
}
