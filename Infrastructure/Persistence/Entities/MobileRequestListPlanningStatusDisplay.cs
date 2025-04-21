using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestListPlanningStatusDisplay
{
    public int PlanningStatusId { get; set; }

    public string DisplayTextAr { get; set; } = null!;

    public string DisplayTextEn { get; set; } = null!;

    public virtual MobileRequestReportPlanningStatusDim PlanningStatus { get; set; } = null!;
}
