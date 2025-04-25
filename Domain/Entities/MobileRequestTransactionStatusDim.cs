using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestTransactionStatusDim
{
    public int MobileRequestTransactionStatusId { get; set; }

    public string StatusDescription { get; set; } = null!;

    public virtual ICollection<MobileRequestTransaction> MobileRequestTransactions { get; set; } = new List<MobileRequestTransaction>();
}
