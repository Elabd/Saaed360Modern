using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationJewelryView
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

    public string? JewelryCategoryCode { get; set; }

    public string? JewelryCategoryDescription { get; set; }

    public string? JewelryCaratCode { get; set; }

    public string? JewelryCaratDescription { get; set; }

    public string? JewelryGenderCode { get; set; }

    public string? JewelryGenderDescription { get; set; }

    public string? JewelryMetalTypeCode { get; set; }

    public string? JewelryMetalTypeDescription { get; set; }

    public string? JewelryStyleCode { get; set; }

    public string? JewelryStyleDescription { get; set; }

    public long OrganizationItemId { get; set; }

    public string OrganizationItemDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? ItemInvolvementDescription { get; set; }
}
