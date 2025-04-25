using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserAttendanceTrace
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public DateTime TimeStamp { get; set; }

    public int Action { get; set; }

    public long? UserAttendancId { get; set; }

    public long? UserAttendanceTraceReferenceId { get; set; }

    public bool? IsFirstCheckIn { get; set; }
}
