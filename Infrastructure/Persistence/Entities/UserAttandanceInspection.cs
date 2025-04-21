using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttandanceInspection
{
    public long Id { get; set; }

    public long? DeviceId { get; set; }

    public long? UserAttendanceId { get; set; }

    public int? CommentCategoryId { get; set; }

    public string? Comment { get; set; }

    public bool? IsWorking { get; set; }

    public DateTime? InsertionDate { get; set; }
}
