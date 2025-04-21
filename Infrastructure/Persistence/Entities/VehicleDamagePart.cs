using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleDamagePart
{
    public int VehicleDamagePartId { get; set; }

    public int DamagePartId { get; set; }

    public int VehicleDataId { get; set; }

    public DateTime? VehicleDamagePartCreatinDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual DamagePartsDim DamagePart { get; set; } = null!;

    public virtual VehicleDatum VehicleData { get; set; } = null!;
}
