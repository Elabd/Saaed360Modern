using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Jewelry
{
    public long ItemId { get; set; }

    public int? JewelryCategoryId { get; set; }

    public int? JewelryCaratId { get; set; }

    public int? JewelryGenderId { get; set; }

    public int? JewelryMetalTypeId { get; set; }

    public int? JewelryStyleId { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual JewelryCaratDim? JewelryCarat { get; set; }

    public virtual JewelryCategoryDim? JewelryCategory { get; set; }

    public virtual JewelryGenderDim? JewelryGender { get; set; }

    public virtual JewelryMetalTypeDim? JewelryMetalType { get; set; }

    public virtual JewelryStyleDim? JewelryStyle { get; set; }
}
