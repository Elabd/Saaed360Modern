using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistTimeFrameDatum
{
    public Guid TimeFrameId { get; set; }

    public int? MonthNumber { get; set; }

    public string? MonthNameAr { get; set; }

    public string? MonthNameEn { get; set; }

    public int? QuarterNumber { get; set; }

    public string? DayNameAr { get; set; }

    public string? DayNameEn { get; set; }

    public int? WeekNumber { get; set; }

    public int? DayNumber { get; set; }
}
