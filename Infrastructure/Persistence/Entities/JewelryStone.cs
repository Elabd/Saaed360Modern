using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class JewelryStone
{
    public long JewelryStoneId { get; set; }

    public Guid JewelryStoneGuid { get; set; }

    public string JewelryStoneDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long SourceId { get; set; }

    public int? JewelryStoneCaratId { get; set; }

    public int? JewelryStoneCategoryId { get; set; }

    public int? JewelryStoneColorId { get; set; }

    public int? JewelryStoneCutId { get; set; }

    public double? StoneQuantity { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual JewelryStoneCaratDim? JewelryStoneCarat { get; set; }

    public virtual JewelryStoneCategoryDim? JewelryStoneCategory { get; set; }

    public virtual ItemColorDim? JewelryStoneColor { get; set; }

    public virtual JewelryStoneCutDim? JewelryStoneCut { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
