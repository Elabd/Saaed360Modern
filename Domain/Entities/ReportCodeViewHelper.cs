using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportCodeViewHelper
{
    public int VehicleDataId { get; set; }

    public int Reportid { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public string? ReportCode { get; set; }

    public int? VehicleRuleId { get; set; }

    public string? PlateNumber { get; set; }

    public long? AdpreportNumber { get; set; }

    public int? AdpstatusId { get; set; }

    public string? StatusId { get; set; }

    public int? CityId { get; set; }

    public int? ReportYear { get; set; }

    public string? SystemCode { get; set; }

    public string? OwnerTcn { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public bool? InEmirates { get; set; }
}
