using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RspVehicleDatum
{
    public long RspVehicleDataId { get; set; }

    public string? PlateNumber { get; set; }

    public int? ReportId { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateCategoryId { get; set; }

    public int? PlateSourceId { get; set; }

    public string? TrafficCode { get; set; }

    public int? ManufactureYearId { get; set; }

    public bool? IsInsured { get; set; }

    public long? VehicleDamagedTypeId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsNoVehiclePresent { get; set; }

    public int? VehicleTypeId { get; set; }

    public virtual YearDim? ManufactureYear { get; set; }

    public virtual ItemRegistrationPlateKindDim? PlateCategory { get; set; }

    public virtual ItemRegistrationPlateColorDim? PlateColor { get; set; }

    public virtual PlateSourceDim? PlateSource { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? PlateType { get; set; }

    public virtual Report? Report { get; set; }

    public virtual ICollection<RspDriverDatum> RspDriverData { get; set; } = new List<RspDriverDatum>();

    public virtual ICollection<RspReportsVehicleDatum> RspReportsVehicleData { get; set; } = new List<RspReportsVehicleDatum>();

    public virtual VehicleDamagedTypeDim? VehicleDamagedType { get; set; }

    public virtual VehicleTypeDim? VehicleType { get; set; }
}
