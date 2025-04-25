using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStoneCutDim
{
    public int JewelryStoneCutId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
