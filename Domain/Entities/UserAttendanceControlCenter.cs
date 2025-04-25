using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class UserAttendanceControlCenter
{
    public long Id { get; set; }

    public long ControlCenterId { get; set; }

    public long UserAttendanceId { get; set; }
}
