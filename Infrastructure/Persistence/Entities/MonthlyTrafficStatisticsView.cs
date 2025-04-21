using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MonthlyTrafficStatisticsView
{
    public long? ReportEmirateId { get; set; }

    public long EmirateId { get; set; }

    public string? EmirateName { get; set; }

    public int Year { get; set; }

    public int Month { get; set; }

    public int ReportCount { get; set; }

    public TimeOnly ReportResponse { get; set; }
}
