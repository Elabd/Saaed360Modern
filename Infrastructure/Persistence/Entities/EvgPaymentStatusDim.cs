using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EvgPaymentStatusDim
{
    public int EvgPaymentStatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<ReportPaymentTransaction> ReportPaymentTransactions { get; set; } = new List<ReportPaymentTransaction>();
}
