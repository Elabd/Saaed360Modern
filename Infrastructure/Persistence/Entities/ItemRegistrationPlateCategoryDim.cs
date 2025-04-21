using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemRegistrationPlateCategoryDim
{
    public int ItemRegistrationPlateCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<EsVehicleInquiry> EsVehicleInquiries { get; set; } = new List<EsVehicleInquiry>();

    public virtual ICollection<ItemRegistration> ItemRegistrations { get; set; } = new List<ItemRegistration>();

    public virtual ICollection<PlateMatrix> PlateMatrices { get; set; } = new List<PlateMatrix>();

    public virtual ICollection<PlateSourceToPlateTypeMap> PlateSourceToPlateTypeMaps { get; set; } = new List<PlateSourceToPlateTypeMap>();

    public virtual ICollection<PlateTypeToPlateClassMap> PlateTypeToPlateClassMaps { get; set; } = new List<PlateTypeToPlateClassMap>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspVehicleDatum> RspVehicleData { get; set; } = new List<RspVehicleDatum>();

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<ViolationVehicleDatum> ViolationVehicleData { get; set; } = new List<ViolationVehicleDatum>();
}

