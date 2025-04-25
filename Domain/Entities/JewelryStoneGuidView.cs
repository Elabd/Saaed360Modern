using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStoneGuidView
{
    public Guid JewelryStoneGuid { get; set; }

    public string JewelryStoneDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public string? JewelryStoneCaratCode { get; set; }

    public string? JewelryStoneCategoryCode { get; set; }

    public string? JewelryStoneColorCode { get; set; }

    public string? JewelryStoneCutCode { get; set; }

    public double? StoneQuantity { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
