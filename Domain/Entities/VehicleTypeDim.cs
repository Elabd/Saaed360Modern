using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleTypeDim
{
    public int VehicleTypeId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public string? Category { get; set; }

    public string? Reference { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspVehicleDatum> RspVehicleData { get; set; } = new List<RspVehicleDatum>();

    public virtual ICollection<VehicleCategoryToVehicleTypeMap> VehicleCategoryToVehicleTypeMaps { get; set; } = new List<VehicleCategoryToVehicleTypeMap>();

    public virtual ICollection<VehicleDatum> VehicleDatumSelectedCausedVehicleTypes { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<VehicleDatum> VehicleDatumVehicleTypes { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<VehicleMatrix> VehicleMatrices { get; set; } = new List<VehicleMatrix>();

    public virtual ICollection<VehicleTypeToVehicleModelMap> VehicleTypeToVehicleModelMaps { get; set; } = new List<VehicleTypeToVehicleModelMap>();

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
