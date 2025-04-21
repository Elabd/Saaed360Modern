using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PrivateReportCode
{
    public long PrivateReportCodeId { get; set; }

    public long ReportId { get; set; }

    public string ReportCode { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string? MobileNumber { get; set; }
}
