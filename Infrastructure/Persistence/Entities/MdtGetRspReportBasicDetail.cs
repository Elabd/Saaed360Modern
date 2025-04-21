using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtGetRspReportBasicDetail
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public long RspReportBasicDetailsId { get; set; }

    public long? ActivityId { get; set; }

    public string? AffectedLanes { get; set; }

    public string? FieldsFactors { get; set; }

    public string? EventTypes { get; set; }

    public double? IncidentLattitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public long? TrafficStatusId { get; set; }

    public long? DamagedLevelId { get; set; }

    public long? IncidentLaneId { get; set; }

    public string? Comments { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentTime { get; set; }

    public string? Description { get; set; }

    public string? Priority { get; set; }

    public string? SourceName { get; set; }
}
