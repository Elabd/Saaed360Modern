using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundOrder
{
    public long Id { get; set; }

    public string? OrderNumber { get; set; }

    public int? PlateNumber { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateCategoryId { get; set; }

    public int VehicleTypeId { get; set; }

    public string CustomerMobileNumber { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public int? ImpoundReasonId { get; set; }

    public string? ImpoundReasonDescription { get; set; }

    public int OrderPriority { get; set; }

    public int AreaId { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public int AuthorityId { get; set; }

    public DateTime CreatedDatetime { get; set; }

    public string? VehicleStatus { get; set; }

    public int? StatusId { get; set; }

    public int NoTrucksReq { get; set; }

    public string? OfficerName { get; set; }

    public string? OfficerMobileNumber { get; set; }

    public string? PoliceRefNumber { get; set; }
}
