using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityFirearmView
{
    public long ItemId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ItemCategoryCode { get; set; }

    public string? ItemCategoryDescription { get; set; }

    public string? ItemStatusCode { get; set; }

    public string? ItemStatusDescription { get; set; }

    public string? ItemMakeModelCode { get; set; }

    public string? ItemMakeModelMake { get; set; }

    public string? ItemMakeModelModel { get; set; }

    public int? ModelYear { get; set; }

    public string? ItemPrimaryColorCode { get; set; }

    public string? ItemPrimaryColorDescription { get; set; }

    public string? ItemSecondaryColorCode { get; set; }

    public string? ItemSecondaryColorDescription { get; set; }

    public string? ItemConditionCode { get; set; }

    public string? ItemConditionDescription { get; set; }

    public string? ItemUsageCode { get; set; }

    public string? ItemUsageDescription { get; set; }

    public string? ItemName { get; set; }

    public string? Description { get; set; }

    public string? SerialIdentification { get; set; }

    public double? ItemValue { get; set; }

    public string? SizeDescription { get; set; }

    public double? HeightMeasure { get; set; }

    public double? LengthMeasure { get; set; }

    public double? WidthMeasure { get; set; }

    public double? WeightMeasure { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public string? FirearmCategoryCode { get; set; }

    public string? FirearmCategoryDescription { get; set; }

    public string? FirearmFinishCode { get; set; }

    public string? FirearmFinishDescription { get; set; }

    public string? FirearmGageCaliberCode { get; set; }

    public string? FirearmGageCaliberDescription { get; set; }

    public string? FirearmActionCategoryCode { get; set; }

    public string? FirearmActionCategoryDescription { get; set; }

    public string? FirearmGripCode { get; set; }

    public string? FirearmGripDescription { get; set; }

    public int AutomaticIndicator { get; set; }

    public double? BarrelLength { get; set; }

    public long ActivityItemId { get; set; }

    public string ActivityItemDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? ItemInvolvementDescription { get; set; }
}
