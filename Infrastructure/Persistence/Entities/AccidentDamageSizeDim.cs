using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AccidentDamageSizeDim
{
    public long AccidentDamageSizeId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<DamagedVehiclePart> DamagedVehicleParts { get; set; } = new List<DamagedVehiclePart>();
}
