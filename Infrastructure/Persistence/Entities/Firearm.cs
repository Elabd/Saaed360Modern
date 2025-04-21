using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Firearm
{
    public long ItemId { get; set; }

    public int? FirearmCategoryId { get; set; }

    public int? FirearmFinishId { get; set; }

    public int? FirearmGageCaliberId { get; set; }

    public int? FirearmActionCategoryId { get; set; }

    public int? FirearmGripId { get; set; }

    public int AutomaticIndicator { get; set; }

    public double? BarrelLength { get; set; }

    public virtual FirearmActionCategoryDim? FirearmActionCategory { get; set; }

    public virtual FirearmCategoryDim? FirearmCategory { get; set; }

    public virtual FirearmFinishDim? FirearmFinish { get; set; }

    public virtual FirearmGageCaliberDim? FirearmGageCaliber { get; set; }

    public virtual FirearmGripDim? FirearmGrip { get; set; }

    public virtual Item Item { get; set; } = null!;
}
