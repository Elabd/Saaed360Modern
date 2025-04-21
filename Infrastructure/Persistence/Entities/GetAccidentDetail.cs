using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetAccidentDetail
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public long? AdpreportNumber { get; set; }

    public int? VehicleRoleId { get; set; }

    public string? VehicleRole { get; set; }

    public string? PlateNumber { get; set; }

    public string? ChasisNumber { get; set; }

    public string? OwnerTcf { get; set; }

    public int? PlateSourceId { get; set; }

    public string? PlateSource { get; set; }

    public string? PlateSourceEn { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleTypeEn { get; set; }

    public int? VehicleBrandId { get; set; }

    public string? VehicleBrand { get; set; }

    public string? VehicleBrandEn { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleModel { get; set; }

    public string? VehicleModelEn { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public string? PlateColor { get; set; }

    public string? PlateColorEn { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public string? PlateType { get; set; }

    public string? PlateKindEn { get; set; }
}
