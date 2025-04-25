using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JewelryStoneView
{
    public long JewelryStoneId { get; set; }

    public string JewelryStoneDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public string? JewelryStoneCaratCode { get; set; }

    public string? JewelryStoneCaratDescription { get; set; }

    public string? JewelryStoneCategoryCode { get; set; }

    public string? JewelryStoneCategoryDescription { get; set; }

    public string? JewelryStoneColorCode { get; set; }

    public string? JewelryStoneColorDescription { get; set; }

    public string? JewelryStoneCutCode { get; set; }

    public string? JewelryStoneCutDescription { get; set; }

    public double? StoneQuantity { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
