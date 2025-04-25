using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OldReportMigration
{
    public long Id { get; set; }

    public long? ReportId { get; set; }

    public long? ActivityId { get; set; }

    public string? IncidentNumber { get; set; }

    public int SystemId { get; set; }
}
