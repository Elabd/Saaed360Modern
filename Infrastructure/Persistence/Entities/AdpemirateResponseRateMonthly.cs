using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AdpemirateResponseRateMonthly
{
    public long Id { get; set; }

    public int EmirateId { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    public TimeOnly ResponseInTime { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int ActiveReportsCounts { get; set; }
}
