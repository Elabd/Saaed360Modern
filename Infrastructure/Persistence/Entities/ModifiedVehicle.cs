using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ModifiedVehicle
{
    public int? VehicleDataId { get; set; }

    public int? ModificationType { get; set; }
}
