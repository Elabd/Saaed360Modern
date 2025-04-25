using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DamagedVehiclePartsDim
{
    public long DamagedPartsId { get; set; }

    public string PartName { get; set; } = null!;

    public string? Code { get; set; }

    public bool? IsActive { get; set; }
}
