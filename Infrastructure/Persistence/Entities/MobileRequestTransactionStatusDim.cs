using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestTransactionStatusDim
{
    public int MobileRequestTransactionStatusId { get; set; }

    public string StatusDescription { get; set; } = null!;

    public virtual ICollection<MobileRequestTransaction> MobileRequestTransactions { get; set; } = new List<MobileRequestTransaction>();
}
