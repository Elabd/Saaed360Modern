using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FirearmGuidView
{
    public Guid ItemGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? ItemCategoryCode { get; set; }

    public string? ItemStatusCode { get; set; }

    public string? ItemMakeModelCode { get; set; }

    public int? ModelYear { get; set; }

    public string? ItemPrimaryColorCode { get; set; }

    public string? ItemSecondaryColorCode { get; set; }

    public string? ItemConditionCode { get; set; }

    public string? ItemUsageCode { get; set; }

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

    public string? FirearmCategoryCode { get; set; }

    public string? FirearmFinishCode { get; set; }

    public string? FirearmGageCaliberCode { get; set; }

    public string? FirearmActionCategoryCode { get; set; }

    public string? FirearmGripCode { get; set; }

    public int AutomaticIndicator { get; set; }

    public double? BarrelLength { get; set; }
}
