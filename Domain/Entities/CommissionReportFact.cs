using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommissionReportFact
{
    public long CommissionReportFactId { get; set; }

    public int? ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? ReportTypeId { get; set; }

    public int? ReportStatusId { get; set; }

    public int? EmiratesId { get; set; }

    public int? CityId { get; set; }

    public int? RegionId { get; set; }

    public bool? IsHotArea { get; set; }

    public DateTime? ReportDateTime { get; set; }

    public DateTime? ActivationDateTime { get; set; }

    public DateTime? CommissionDateTime { get; set; }

    public long? CreatedBy { get; set; }

    public int? UserNationalityCategoryId { get; set; }

    public int? CommissionTypeId { get; set; }

    public int? PersonNationalityId { get; set; }

    public int? OldStatus { get; set; }
}
