using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleModelDim
{
    public int VehicleModelId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public int? VehicleBrandId { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<RoadAssistVehicle> RoadAssistVehicles { get; set; } = new List<RoadAssistVehicle>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual VehicleBrandDim? VehicleBrand { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<VehicleMatrix> VehicleMatrices { get; set; } = new List<VehicleMatrix>();

    public virtual ICollection<VehicleTypeToVehicleModelMap> VehicleTypeToVehicleModelMaps { get; set; } = new List<VehicleTypeToVehicleModelMap>();
}
