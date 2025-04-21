using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistVehicle
{
    public Guid VehicleId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public int PlateSourceId { get; set; }

    public int ItemRegistrationPlateColorId { get; set; }

    public string PlateNumber { get; set; } = null!;

    public int VehicleBrandId { get; set; }

    public int ColorId { get; set; }

    public int? VehicleModelId { get; set; }

    public virtual ColorDim Color { get; set; } = null!;

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual ItemRegistrationPlateColorDim ItemRegistrationPlateColor { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual PlateSourceDim PlateSource { get; set; } = null!;

    public virtual ICollection<RoadAssistProviderVehicle> RoadAssistProviderVehicles { get; set; } = new List<RoadAssistProviderVehicle>();

    public virtual ICollection<RoadAssistUserVehicle> RoadAssistUserVehicles { get; set; } = new List<RoadAssistUserVehicle>();

    public virtual VehicleBrandDim VehicleBrand { get; set; } = null!;

    public virtual VehicleModelDim? VehicleModel { get; set; }
}
