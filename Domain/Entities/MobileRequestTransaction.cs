using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestTransaction
{
    public long MobileRequestTransactionId { get; set; }

    public long MobileRequestId { get; set; }

    public int MobileRequestStatusId { get; set; }

    public long CreatedById { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual Person CreatedBy { get; set; } = null!;

    public virtual MobileRequest MobileRequest { get; set; } = null!;

    public virtual MobileRequestTransactionStatusDim MobileRequestStatus { get; set; } = null!;
}
