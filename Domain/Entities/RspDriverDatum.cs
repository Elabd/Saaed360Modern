using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RspDriverDatum
{
    public long RspDriverDataId { get; set; }

    public string? TrafficCode { get; set; }

    public string? LicenseNumber { get; set; }

    public long? RspVehicleDataId { get; set; }

    public int? LicenseSourceId { get; set; }

    public string? DriverName { get; set; }

    public int? NationalityId { get; set; }

    public int? GenderId { get; set; }

    public string? PhoneNumber { get; set; }

    public int? LicenseCategoryId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsDriverHasNoLicense { get; set; }

    public virtual GenderDim? Gender { get; set; }

    public virtual LicenseCategoryDim? LicenseCategory { get; set; }

    public virtual LicensePlateListSourceDim? LicenseSource { get; set; }

    public virtual NationalityDim? Nationality { get; set; }

    public virtual RspVehicleDatum? RspVehicleData { get; set; }
}
