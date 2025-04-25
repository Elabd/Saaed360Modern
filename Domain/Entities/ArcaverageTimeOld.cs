using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ArcaverageTimeOld
{
    public DateOnly? Date { get; set; }

    public int? TotalReports { get; set; }

    public decimal? Average { get; set; }
}
