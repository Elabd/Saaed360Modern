using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VReportDriverNumber
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public string? MobileNumber { get; set; }
}
