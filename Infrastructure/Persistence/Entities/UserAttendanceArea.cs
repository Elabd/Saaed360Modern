using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttendanceArea
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public long UserAttendanceId { get; set; }
}
