using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RepairPermissionReportView
{
    public long ObjectionId { get; set; }

    public int TypeId { get; set; }

    public string TypeNameArabic { get; set; } = null!;

    public string TypeNameEnglish { get; set; } = null!;

    public DateTime? IssuanceDate { get; set; }

    public long EmirateId { get; set; }

    public string EmirateNameArabic { get; set; } = null!;

    public string? EmirateNameEnglish { get; set; }

    public int? AccidentCountryId { get; set; }

    public string? AccidentCountryNameArabic { get; set; }

    public string? AccidentCountryNameEnglish { get; set; }

    public DateTime? AccidentDate { get; set; }

    public string Notes { get; set; } = null!;

    public string? Name { get; set; }

    public string? EmiratesId { get; set; }

    public string? ApplicantTcn { get; set; }

    public string? DamagesDescription { get; set; }

    public string? PlateNumber { get; set; }

    public int? PlateSourceId { get; set; }

    public string? PlateSourceArabic { get; set; }

    public string? PlateSourceEnglish { get; set; }

    public int? PlateCategoryId { get; set; }

    public string? PlateCategoryArabic { get; set; }

    public string? PlateCategoryEnglish { get; set; }

    public int? PlateColorId { get; set; }

    public string? PlateColorArabic { get; set; }

    public string? PlateColorEnglish { get; set; }

    public int? VehicleColorId { get; set; }

    public string? VehicleColorArabic { get; set; }

    public string? VehicleColorEnglish { get; set; }

    public int? BrandId { get; set; }

    public string? BrandArabic { get; set; }

    public string? BrandEnglish { get; set; }

    public int? ModelId { get; set; }

    public string? ModelArabic { get; set; }

    public string? ModelEnglish { get; set; }

    public string? ChassisNumber { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? InsuranceCompanyArabic { get; set; }

    public string? InsuranceCompanyEnglish { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? InsuranceTypeArabic { get; set; }

    public string? InsuranceTypeEnglish { get; set; }

    public string? PolicyNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? OwnerName { get; set; }

    public string? TrafficCode { get; set; }

    public int? NationalityId { get; set; }

    public string? NationalityIdArabic { get; set; }

    public string? NationalityIdEnglish { get; set; }

    public string? EngineNumber { get; set; }

    public int? ManufactueYearId { get; set; }

    public string? ManufactueYear { get; set; }

    public int? CountryOfOriginId { get; set; }

    public string? CountryOfOriginArabic { get; set; }

    public string? CountryOfOriginEnglish { get; set; }

    public string? WeightEmpty { get; set; }

    public string? WeightNonEmpty { get; set; }

    public string? VehicleDesc { get; set; }
}
