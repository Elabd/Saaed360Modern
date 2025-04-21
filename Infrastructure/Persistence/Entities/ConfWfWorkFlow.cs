using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConfWfWorkFlow
{
    public long WorkFlowId { get; set; }

    public string? WorkFlowName { get; set; }

    public virtual ICollection<ConfWfTransaction> ConfWfTransactions { get; set; } = new List<ConfWfTransaction>();
}
