using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DateTimeDim
{
    public int DateTimeId { get; set; }

    public DateOnly? DayDate { get; set; }

    public int? FiscalYear { get; set; }

    public int? FiscalMonth { get; set; }

    public string? FiscalMonthName { get; set; }

    public int? FiscalQuarter { get; set; }

    public int? CalendarYear { get; set; }

    public int? CalendarMonth { get; set; }

    public string? CalendarMonthName { get; set; }

    public int? CalendarQuarter { get; set; }

    public string? Season { get; set; }

    public bool? IsHoliday { get; set; }

    public int? Day { get; set; }

    public TimeOnly? DayTime { get; set; }

    public string? TimePeriod { get; set; }

    public string? DayNight { get; set; }

    public int? Hour24 { get; set; }

    public int? Hour { get; set; }

    public int? Minute { get; set; }

    public string? DayName { get; set; }

    public bool? IsWeekend { get; set; }

    public DateTime? DayDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
