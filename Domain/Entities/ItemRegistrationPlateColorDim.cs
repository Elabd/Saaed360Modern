using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemRegistrationPlateColorDim
{
    public int ItemRegistrationPlateColorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();

    public virtual ICollection<EsVehicleInquiry> EsVehicleInquiries { get; set; } = new List<EsVehicleInquiry>();

    public virtual ICollection<PlateClassToPlateColorMap> PlateClassToPlateColorMaps { get; set; } = new List<PlateClassToPlateColorMap>();

    public virtual ICollection<PlateMatrix> PlateMatrices { get; set; } = new List<PlateMatrix>();

    public virtual ICollection<RoadAssistVehicle> RoadAssistVehicles { get; set; } = new List<RoadAssistVehicle>();

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<RspVehicleDatum> RspVehicleData { get; set; } = new List<RspVehicleDatum>();

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();

    public virtual ICollection<ViolationVehicleDatum> ViolationVehicleData { get; set; } = new List<ViolationVehicleDatum>();
}

