using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EscortInfo
{
    public long EscortInfoId { get; set; }

    public long? EscortId { get; set; }

    public string RepresentativeName { get; set; } = null!;

    public string ContactNumber { get; set; } = null!;

    public string LocationFrom { get; set; } = null!;

    public string LocationTo { get; set; } = null!;

    public string? LoadType { get; set; }

    public double? Weight { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public int? NumberOfPatrols { get; set; }

    public double? EscortAmount { get; set; }

    public double? EscortTax { get; set; }

    public double? TotalAmount { get; set; }

    public double? AmountAfterDiscountWithoutVat { get; set; }

    public double? VatafterDiscount { get; set; }

    public double? TotalAmountAfterDiscount { get; set; }

    public DateTime? EscortDateFrom { get; set; }

    public DateTime? EscortDateTo { get; set; }

    public bool? IsContractedCompany { get; set; }

    public string? CancelReason { get; set; }

    public string? ReturnReason { get; set; }

    public string? ReservationSerial { get; set; }

    public string? PolicePermitNumber { get; set; }

    public DateTime? PolicePermitStartDate { get; set; }

    public DateTime? PolicePermitEndDate { get; set; }

    public int? VehiclesCount { get; set; }

    public int? NewPatrolsNumber { get; set; }

    public int? PatrolBalancNumber { get; set; }

    public bool? IsPatrolsBalanceUsed { get; set; }

    public virtual Escort? Escort { get; set; }
}
