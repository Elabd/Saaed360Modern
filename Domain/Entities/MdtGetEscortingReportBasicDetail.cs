using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtGetEscortingReportBasicDetail
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public long? ActivityId { get; set; }

    public string? ReportDescription { get; set; }

    public long EscortingReportBasicDetailsId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentTime { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public string? SourceName { get; set; }
}
