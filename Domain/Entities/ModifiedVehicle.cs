using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ModifiedVehicle
{
    public int? VehicleDataId { get; set; }

    public int? ModificationType { get; set; }
}
