using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestReportPlanningStatusDim
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string DescriptionAr { get; set; } = null!;

    public string DescriptionEn { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public virtual MobileRequestListPlanningStatusDisplay? MobileRequestListPlanningStatusDisplay { get; set; }

    public virtual ICollection<MobileRequestReportPlanningStatusLog> MobileRequestReportPlanningStatusLogNewStatusNavigations { get; set; } = new List<MobileRequestReportPlanningStatusLog>();

    public virtual ICollection<MobileRequestReportPlanningStatusLog> MobileRequestReportPlanningStatusLogOldStatusNavigations { get; set; } = new List<MobileRequestReportPlanningStatusLog>();

    public virtual ICollection<MobileRequest> MobileRequests { get; set; } = new List<MobileRequest>();
}
