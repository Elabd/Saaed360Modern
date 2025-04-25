using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportStatusToReportTypeMap
{
    public int ReportTypeId { get; set; }

    public int ReportStatusId { get; set; }

    public int? ReportStatusToReportTypeMapId { get; set; }

    public bool? IsTechnicalSupport { get; set; }

    public virtual ReportStatusDim ReportStatus { get; set; } = null!;

    public virtual ReportTypeDim ReportType { get; set; } = null!;
}
