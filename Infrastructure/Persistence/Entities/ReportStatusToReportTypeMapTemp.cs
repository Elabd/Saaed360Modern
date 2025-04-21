using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportStatusToReportTypeMapTemp
{
    public int ReportTypeId { get; set; }

    public int ReportStatusId { get; set; }

    public int? ReportStatusToReportTypeMapId { get; set; }

    public bool? IsTechnicalSupport { get; set; }
}
