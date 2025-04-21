using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleBrandDim
{
    public int VehicleBrandId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<RoadAssistVehicle> RoadAssistVehicles { get; set; } = new List<RoadAssistVehicle>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<VehicleMatrix> VehicleMatrices { get; set; } = new List<VehicleMatrix>();

    public virtual ICollection<VehicleModelDim> VehicleModelDims { get; set; } = new List<VehicleModelDim>();
}
