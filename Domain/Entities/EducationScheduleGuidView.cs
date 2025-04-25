using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationScheduleGuidView
{
    public Guid PersonEducationGuid { get; set; }

    public Guid EducationScheduleGuid { get; set; }

    public string ScheduleName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public string? EducationScheduleDayCode { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
