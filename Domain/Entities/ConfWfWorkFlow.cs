using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ConfWfWorkFlow
{
    public long WorkFlowId { get; set; }

    public string? WorkFlowName { get; set; }

    public virtual ICollection<ConfWfTransaction> ConfWfTransactions { get; set; } = new List<ConfWfTransaction>();
}
