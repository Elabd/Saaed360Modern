using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttendanceLog
{
    public long Id { get; set; }

    public DateTime? OldCheckInTime { get; set; }

    public DateTime? NewCheckInTime { get; set; }

    public DateTime? OldCheckOutTime { get; set; }

    public DateTime? NewCheckoOutTime { get; set; }

    public string? OldComment { get; set; }

    public string? NewComment { get; set; }

    public int? OldModificationReasonId { get; set; }

    public int? NewModificationReasonId { get; set; }

    public int? Action { get; set; }

    public DateTime TimeStamp { get; set; }

    public long UserId { get; set; }

    public long? UserAttendanceId { get; set; }
}
