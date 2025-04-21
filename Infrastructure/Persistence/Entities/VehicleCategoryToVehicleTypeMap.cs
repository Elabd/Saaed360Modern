using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleCategoryToVehicleTypeMap
{
    public long Id { get; set; }

    public int? VehicleCategoryId { get; set; }

    public int? VehicleTypeId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual VehicleCategoryDim? VehicleCategory { get; set; }

    public virtual VehicleTypeDim? VehicleType { get; set; }
}
