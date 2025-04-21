using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AdpemirateResponseRate
{
    public long Id { get; set; }

    public int EmirateId { get; set; }

    public int Day { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public DateTime ReportDateTime { get; set; }

    public long AccidentsCount { get; set; }

    public TimeOnly ResponseInTime { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int ActiveReportsCounts { get; set; }

    public int ResponseTimeInSecs { get; set; }
}
