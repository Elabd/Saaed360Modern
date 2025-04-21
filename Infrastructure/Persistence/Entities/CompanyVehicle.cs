using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CompanyVehicle
{
    public long CompanyVehicleId { get; set; }

    public long? CompanyId { get; set; }

    public string? PlateNumber { get; set; }

    public int? VehicleCategoryId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? PlateTypeId { get; set; }

    public string? OwnerName { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleType { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<EscortVehicle> EscortVehicles { get; set; } = new List<EscortVehicle>();
}
