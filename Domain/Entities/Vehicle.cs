using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Vehicle
{
    public long ItemId { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? MotorCarrierIdentification { get; set; }

    public string? Identification { get; set; }

    public int? DoorQuantity { get; set; }

    public int? EngineQuantity { get; set; }

    public int? EngineCylinderQuantity { get; set; }

    public int? SeatQuantity { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual VehicleTypeDim? VehicleType { get; set; }
}
