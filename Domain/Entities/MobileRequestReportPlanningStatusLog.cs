using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestReportPlanningStatusLog
{
    public long Id { get; set; }

    public int? OldStatus { get; set; }

    public int NewStatus { get; set; }

    public DateTime CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual MobileRequestReportPlanningStatusDim NewStatusNavigation { get; set; } = null!;

    public virtual MobileRequestReportPlanningStatusDim? OldStatusNavigation { get; set; }
}
