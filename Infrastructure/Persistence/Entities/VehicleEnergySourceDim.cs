using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleEnergySourceDim
{
    public int VehicleEnergySourceId { get; set; }

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime VersionDateTime { get; set; }
}
