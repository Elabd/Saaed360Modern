using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedCommunicationPercentageReportView
{
    public long Id { get; set; }

    public int? ReportCount { get; set; }

    public int? YearofReport { get; set; }

    public int? MonthOfReport { get; set; }

    public string? IncidentSource { get; set; }
}
