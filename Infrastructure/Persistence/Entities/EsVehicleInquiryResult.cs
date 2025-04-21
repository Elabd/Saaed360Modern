using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsVehicleInquiryResult
{
    public int Id { get; set; }

    public int? VehicleInquiryId { get; set; }

    public string? OwnerName { get; set; }

    public int? NationalityId { get; set; }

    public string? Nationality { get; set; }

    public string? TrafficCode { get; set; }

    public string? Address { get; set; }

    public string? ChasisNumber { get; set; }

    public string? EngineNumber { get; set; }

    public int? VehicleBrandId { get; set; }

    public string? VehicleBrand { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleModel { get; set; }

    public int? VehicleColorId { get; set; }

    public int? VehicleClassId { get; set; }

    public string? VehicleClass { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleColor { get; set; }

    public int? CountryOfOriginId { get; set; }

    public string? CountryOfOrigin { get; set; }

    public int? ManufactueYearId { get; set; }

    public string? ManufactureYear { get; set; }

    public string? WeightEmpty { get; set; }

    public string? WeightNonEmpty { get; set; }

    public string? VehicleDesc { get; set; }

    public virtual EsVehicleInquiry? VehicleInquiry { get; set; }
}
