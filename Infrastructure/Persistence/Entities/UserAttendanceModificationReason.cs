using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttendanceModificationReason
{
    public int Id { get; set; }

    public string? Description { get; set; }
}
