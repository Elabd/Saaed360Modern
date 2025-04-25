using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserAttendanceReportView
{
    public long UserAttendanceId { get; set; }

    public string FullName { get; set; } = null!;

    public string? UserName { get; set; }

    public string? Role { get; set; }

    public string? Computer { get; set; }

    public string? Internet { get; set; }

    public string? Program { get; set; }

    public string? Mobiles { get; set; }

    public string? Instrument { get; set; }

    public string? CallingSystem { get; set; }

    public DateTime? CheckInTime { get; set; }

    public DateTime? CheckoutTime { get; set; }

    public long? UserId { get; set; }

    public string? Comment { get; set; }

    public int? UserAttendanceModificationReasonId { get; set; }

    public long? ControlCenterId { get; set; }

    public long? AreaId { get; set; }
}
