using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArcaverageTime
{
    public DateOnly? Date { get; set; }

    public int? TotalReports { get; set; }

    public decimal? Average { get; set; }

    public int? TotalReportsWithin15 { get; set; }

    public decimal? AverageReportsWithin15 { get; set; }
}
