using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadAssistDayPeriod
{
    public Guid PeriodId { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public string PeriodNameEn { get; set; } = null!;

    public string PeriodNameAr { get; set; } = null!;

    public int? PeriodOrder { get; set; }
}
