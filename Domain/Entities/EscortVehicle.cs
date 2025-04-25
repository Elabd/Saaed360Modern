using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortVehicle
{
    public long EscortVehicleId { get; set; }

    public long EscortId { get; set; }

    public long CompanyVehicleId { get; set; }

    public virtual CompanyVehicle CompanyVehicle { get; set; } = null!;

    public virtual Escort Escort { get; set; } = null!;
}
