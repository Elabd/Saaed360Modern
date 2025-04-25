using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewRenewReport
{
    public long RequestId { get; set; }

    public DateTime? CreationDate { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? VehicleDataId { get; set; }

    public string? ReportCode { get; set; }

    public int? VehicleRuleId { get; set; }
}
