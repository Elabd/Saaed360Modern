using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationScheduleView
{
    public long EducationScheduleId { get; set; }

    public long PersonEducationId { get; set; }

    public string ScheduleName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public string? EducationScheduleDayCode { get; set; }

    public string? EducationScheduleDayDescription { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
