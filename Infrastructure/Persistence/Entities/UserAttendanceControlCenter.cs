using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttendanceControlCenter
{
    public long Id { get; set; }

    public long ControlCenterId { get; set; }

    public long UserAttendanceId { get; set; }
}
