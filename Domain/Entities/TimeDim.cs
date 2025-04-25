using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TimeDim
{
    public int TimeId { get; set; }

    public TimeOnly? Time { get; set; }

    public string? Period { get; set; }

    public string? DayNight { get; set; }

    public int? Hour24 { get; set; }

    public int? Minute { get; set; }

    public int? Hour { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
