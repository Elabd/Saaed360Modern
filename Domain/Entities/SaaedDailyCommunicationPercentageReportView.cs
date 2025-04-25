using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedDailyCommunicationPercentageReportView
{
    public long Id { get; set; }

    public int? ReportCount { get; set; }

    public int? YearofReport { get; set; }

    public int? MonthOfReport { get; set; }

    public int? DayOfReport { get; set; }

    public string? IncidentSource { get; set; }
}
