using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VMdtConsentViewVehicleData
{
    public long CompromiseId { get; set; }

    public long ActivityId { get; set; }

    public int VehicleDataId { get; set; }

    public string? PlateNumber { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public string? PlateColorDesc { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public string? PlateKindDesc { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public string? PlateCategorDesc { get; set; }

    public int? PlateSourceId { get; set; }

    public string? PlateSourceDesc { get; set; }

    public int? VehicleDataType { get; set; }

    public string? VehicleDataTypeDesc { get; set; }

    public int? VehicleType { get; set; }

    public string? VehicleTypeDesc { get; set; }

    public bool? IsVehicleWithoutPlateNumber { get; set; }

    public string? VehicleDescription { get; set; }
}
