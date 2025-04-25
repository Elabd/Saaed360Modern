using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityAircraftGuidView
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

    public Guid? BaseAirportLocationGuid { get; set; }

    public string? AircraftCategoryCode { get; set; }

    public string? FuselageColorCode { get; set; }

    public string? WingColorCode { get; set; }

    public string? AircraftUsageCode { get; set; }

    public string? TailIndentification { get; set; }

    public int? EngineQuantity { get; set; }

    public int? EngineCylinderQuantity { get; set; }

    public Guid ActivityItemGuid { get; set; }

    public string ActivityItemDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public string? ItemInvolvementCode { get; set; }
}
