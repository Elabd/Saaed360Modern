using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TransactionType
{
    public int TransactionTypeId { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<ActivityTransaction> ActivityTransactions { get; set; } = new List<ActivityTransaction>();
}
