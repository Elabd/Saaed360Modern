using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SellAnyCar
{
    public long Id { get; set; }

    public string? ReportNumber { get; set; }

    public int? BrandId { get; set; }

    public string? ChassisNumber { get; set; }

    public int? ManufactueYearId { get; set; }

    public int? ModelId { get; set; }

    public int? TypeId { get; set; }

    public string? OwnerName { get; set; }

    public DateTime OrderDate { get; set; }

    public string? PlateNumber { get; set; }

    public short? SaaedSatisfactionAnswer { get; set; }

    public bool? IsInterestedInSellingCar { get; set; }

    public bool? IsCarInformationShared { get; set; }

    public string? ServiceResponse { get; set; }

    public string? PhoneNumber { get; set; }

    public int? Status { get; set; }

    public DateTime? StatusRecievedTime { get; set; }
}
