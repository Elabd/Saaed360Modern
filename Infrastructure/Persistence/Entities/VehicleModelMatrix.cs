using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleModelMatrix
{
    public long Id { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public int? VehicleTypeId { get; set; }
}
