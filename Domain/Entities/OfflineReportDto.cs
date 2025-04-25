using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OfflineReportDto
{
    public long Id { get; set; }

    public string? ReportNumber { get; set; }

    public string? IncidentNumber { get; set; }

    public string? ReportDto { get; set; }

    public long? PersonId { get; set; }
}
