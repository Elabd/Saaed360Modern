using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EducationScheduleDayDim
{
    public int EducationScheduleDayId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<EducationSchedule> EducationSchedules { get; set; } = new List<EducationSchedule>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
