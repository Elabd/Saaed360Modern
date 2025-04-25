using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FinancialReportHelper
{
    public int? Reportid { get; set; }

    public long? AdpreportNumber { get; set; }

    public string? StatusId { get; set; }

    public int? AdpstatusId { get; set; }

    public int? ReportTypeId { get; set; }

    public long? CityId { get; set; }

    public long? EmiratesId { get; set; }

    public DateTime? UploadedTime { get; set; }

    public DateTime? PaymentTime { get; set; }

    public int ReportCost { get; set; }
}
