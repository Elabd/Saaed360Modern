using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleTypeToVehicleModelMap
{
    public long Id { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleModelId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual VehicleModelDim? VehicleModel { get; set; }

    public virtual VehicleTypeDim? VehicleType { get; set; }
}
