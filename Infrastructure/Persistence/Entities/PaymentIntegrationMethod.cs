using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PaymentIntegrationMethod
{
    public int MethodId { get; set; }

    public string MethodName { get; set; } = null!;

    public virtual ICollection<PaymentIntegrationLog> PaymentIntegrationLogs { get; set; } = new List<PaymentIntegrationLog>();
}
