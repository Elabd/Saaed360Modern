using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConfWfTransaction
{
    public long TransactionId { get; set; }

    public string? TransactionName { get; set; }

    public long? WorkFlowId { get; set; }

    public virtual ICollection<ConfWfLevel> ConfWfLevels { get; set; } = new List<ConfWfLevel>();

    public virtual ConfWfWorkFlow? WorkFlow { get; set; }
}
