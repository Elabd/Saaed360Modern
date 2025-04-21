using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonDrugView
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

    public string? DrugCategoryCode { get; set; }

    public string? DrugCategoryDescription { get; set; }

    public string? DrugSubstanceFormCode { get; set; }

    public string? DrugSubstanceFormDescription { get; set; }

    public string? DrugContainerCode { get; set; }

    public string? DrugContainerDescription { get; set; }

    public string? DrugCompositionCode { get; set; }

    public string? DrugCompositionDescription { get; set; }

    public string? DrugFoundCode { get; set; }

    public string? DrugFoundDescription { get; set; }

    public double? QuantityMeasure { get; set; }

    public long PersonItemId { get; set; }

    public string PersonItemDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public string? ItemInvolvementCode { get; set; }

    public string? ItemInvolvementDescription { get; set; }
}
