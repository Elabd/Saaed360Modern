using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MotoriGetVehicleInquery
{
    public int VehicleDataId { get; set; }

    public string? ChasisNumber { get; set; }

    public string? PlateNumber { get; set; }

    public string? PlaceOfIssue { get; set; }

    public int? PlateType { get; set; }

    public string? OwnerNameArabic { get; set; }

    public string? OwnerNameEnglish { get; set; }

    public int? OnwerNationalityCode { get; set; }

    public string? OwnerTcn { get; set; }

    public int? InsureCompanyCode { get; set; }

    public DateTime? InsuranceExpirationDate { get; set; }

    public string? PolicyNumber { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? PolicyType { get; set; }

    public int? OriginId { get; set; }

    public string? Origin { get; set; }

    public string? VehicleType { get; set; }

    public int? VehicleColor { get; set; }

    public string? VehicleCategory { get; set; }

    public string? EmptyWeight { get; set; }

    public string? EngineNumber { get; set; }

    public int? MakeCode { get; set; }

    public int? ModelCode { get; set; }

    public int? PlateCategoryCode { get; set; }

    public int? PlateColorCode { get; set; }

    public int? PlateSourceCode { get; set; }

    public string? ModelYear { get; set; }
}
