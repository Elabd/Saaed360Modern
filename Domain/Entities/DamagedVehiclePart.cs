using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DamagedVehiclePart
{
    public int DamagedVehiclePartsId { get; set; }

    public string? DamagedPartsDetails { get; set; }

    public int? VehicleDataId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public string? DamagePartsDescription { get; set; }

    public long? AccidentDamageSizeId { get; set; }

    public virtual AccidentDamageSizeDim? AccidentDamageSize { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual VehicleDatum? VehicleData { get; set; }
}
