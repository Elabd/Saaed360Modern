using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VehicleCategoryDim
{
    public int VehicleCategoryId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<VehicleCategoryToLicenseCategoryMap> VehicleCategoryToLicenseCategoryMaps { get; set; } = new List<VehicleCategoryToLicenseCategoryMap>();

    public virtual ICollection<VehicleCategoryToVehicleTypeMap> VehicleCategoryToVehicleTypeMaps { get; set; } = new List<VehicleCategoryToVehicleTypeMap>();

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<VehicleMatrix> VehicleMatrices { get; set; } = new List<VehicleMatrix>();
}
