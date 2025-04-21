using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundOrderVehicle
{
    public long Id { get; set; }

    public long ImpoundOrderId { get; set; }

    public bool IsVehicle { get; set; }

    public string? NotVehicleDescription { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateNumber { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateCategoryId { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int? VehicleTypeId { get; set; }

    public int ImpoundTypeId { get; set; }

    public int? ImpoundReasonId { get; set; }

    public string? ImpoundReasonDescription { get; set; }

    public int StatusId { get; set; }
}
