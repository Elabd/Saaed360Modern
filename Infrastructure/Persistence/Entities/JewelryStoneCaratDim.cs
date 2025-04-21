using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JewelryStoneCaratDim
{
    public int JewelryStoneCaratId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<JewelryStone> JewelryStones { get; set; } = new List<JewelryStone>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
