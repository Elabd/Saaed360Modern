using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityConvertToStationArc
{
    public long Id { get; set; }

    public long? ActivityId { get; set; }

    public int? ActivityReasonId { get; set; }

    public long? OrganizationId { get; set; }

    public string? Comment { get; set; }

    public long? CreatedBy { get; set; }

    public long? LastModifiedBy { get; set; }

    public DateTime? Createdtime { get; set; }

    public int? ReportId { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual ActivityReasonDim? ActivityReason { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual Report? Report { get; set; }
}
