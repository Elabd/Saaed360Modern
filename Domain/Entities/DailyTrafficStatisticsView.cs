using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DailyTrafficStatisticsView
{
    public long? ReportEmirateId { get; set; }

    public long EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int Day { get; set; }

    public int ReportCount { get; set; }

    public TimeOnly ReportResponse { get; set; }
}
