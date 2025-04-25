using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustodyTransfer
{
    public long ActivityId { get; set; }

    public int CustodyTransferActionId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CustodyTransferActionDim CustodyTransferAction { get; set; } = null!;
}
