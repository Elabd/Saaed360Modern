using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleDamagedPart
{
    public long VehicleDamagedPartId { get; set; }

    public int? VehicleDataId { get; set; }

    public string? DamagedPartName { get; set; }

    public int? DamagedPartSeverityId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public bool? IsDeleted { get; set; }

    public int? DamagePartId { get; set; }

    public virtual DamagedPartSeverityDim? DamagedPartSeverity { get; set; }

    public virtual VehicleDatum? VehicleData { get; set; }
}
