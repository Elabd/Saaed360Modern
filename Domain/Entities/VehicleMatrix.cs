using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleMatrix
{
    public long VehicleMatrixId { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public int? VehicleKindId { get; set; }

    public int? VehicleTypeId { get; set; }

    public bool? IsActive { get; set; }

    public virtual VehicleBrandDim? VehicleBrand { get; set; }

    public virtual VehicleTypeDim? VehicleKind { get; set; }

    public virtual VehicleModelDim? VehicleModel { get; set; }

    public virtual VehicleCategoryDim? VehicleType { get; set; }
}
