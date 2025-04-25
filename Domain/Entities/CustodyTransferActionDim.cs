using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CustodyTransferActionDim
{
    public int CustodyTransferActionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<CustodyTransfer> CustodyTransfers { get; set; } = new List<CustodyTransfer>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
