using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VGetIncidentAreaByreport
{
    public int ActivityReportId { get; set; }

    public long? ActivityId { get; set; }

    public int? ReportId { get; set; }

    public long? EmirateId { get; set; }

    public long? CityId { get; set; }

    public long? SectorId { get; set; }
}
