using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VReportAccessLog
{
    public string ReportNumber { get; set; } = null!;

    public int ReportAccessChannelId { get; set; }

    public string ReportChannelDesc { get; set; } = null!;

    public long? ReportAccessVehicleDataId { get; set; }

    public string? ReportCode { get; set; }

    public string? ChasisNumber { get; set; }

    public string? PlateNumber { get; set; }

    public string? TrafficCode { get; set; }

    public int? PlateSourceId { get; set; }

    public long? ReportPrivateReportCodeId { get; set; }

    public bool IsReportExpired { get; set; }

    public bool IsReportNotViewedPayment { get; set; }

    public DateTime ReportAccessDatetime { get; set; }

    public long? EmiratesId { get; set; }

    public string EmirateName { get; set; } = null!;
}
