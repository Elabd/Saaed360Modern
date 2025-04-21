using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArcaverageTime15
{
    public DateOnly? Date { get; set; }

    public int? TotalReports { get; set; }

    public decimal? Average { get; set; }

    public int? CountIncidents15 { get; set; }
}
