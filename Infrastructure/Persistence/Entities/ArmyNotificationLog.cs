using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArmyNotificationLog
{
    public long LogId { get; set; }

    public DateTime CreationDate { get; set; }

    public string Email { get; set; } = null!;

    public int VehicleDataId { get; set; }

    public virtual VehicleDatum VehicleData { get; set; } = null!;
}
