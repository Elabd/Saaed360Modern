using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportAccessLog
{
    public long ReportAccessLogId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public int ReportAccessChannelId { get; set; }

    public string ReportAccessCode { get; set; } = null!;

    public long? ReportAccessVehicleDataId { get; set; }

    public long? ReportPrivateReportCodeId { get; set; }

    public bool IsReportExpired { get; set; }

    public bool IsReportNotViewedPayment { get; set; }

    public DateTime ReportAccessDatetime { get; set; }
}
