using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArcaverageTime15
{
    public DateOnly? Date { get; set; }

    public int? TotalReports { get; set; }

    public decimal? Average { get; set; }

    public int? CountIncidents15 { get; set; }
}
