using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RspReportBasicDetail
{
    public long RspReportBasicDetailsId { get; set; }

    public int? ReportId { get; set; }

    public string? AffectedLanes { get; set; }

    public string? FieldsFactors { get; set; }

    public string? EventTypes { get; set; }

    public double? IncidentLattitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public long? TrafficStatusId { get; set; }

    public long? DamagedLevelId { get; set; }

    public long? IncidentLaneId { get; set; }

    public string? Comments { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual RspDamagedLevelDim? DamagedLevel { get; set; }

    public virtual IncidentLaneDim? IncidentLane { get; set; }

    public virtual Report? Report { get; set; }

    public virtual TrafficStatusDim? TrafficStatus { get; set; }
}
