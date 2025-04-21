using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewAccidentHistoryByChassisNumber
{
    public string? ReportNumber { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public string? ChasisNumber { get; set; }

    public string RoleInAccident { get; set; } = null!;

    public string? ReportType { get; set; }

    public string? ReportStatus { get; set; }
}
