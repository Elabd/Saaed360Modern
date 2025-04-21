using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionPatrolAttendance
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public Guid TransporterId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpectedEndDate { get; set; }

    public DateTime? ActualEndDate { get; set; }

    public long UserId { get; set; }

    public int AttendanceStatus { get; set; }

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;

    public virtual Person User { get; set; } = null!;
}
