using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationSchedule
{
    public long EducationScheduleId { get; set; }

    public long PersonEducationId { get; set; }

    public Guid PersonEducationGuid { get; set; }

    public Guid EducationScheduleGuid { get; set; }

    public long SourceId { get; set; }

    public string ScheduleName { get; set; } = null!;

    public DateOnly? EffectiveDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public int EducationScheduleDayId { get; set; }

    public TimeOnly? StartTime { get; set; }

    public TimeOnly? EndTime { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual EducationScheduleDayDim EducationScheduleDay { get; set; } = null!;

    public virtual PersonEducation PersonEducation { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
