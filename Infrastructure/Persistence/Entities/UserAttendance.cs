using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class UserAttendance
{
    public long Id { get; set; }

    public long? UserId { get; set; }

    public DateTime? FirstCheckInTime { get; set; }

    public DateTime? CheckOutTime { get; set; }

    public bool? IsCheckIn { get; set; }

    public bool? IsCheckout { get; set; }

    public DateTime InsertionDate { get; set; }

    public DateTime? ModifyDate { get; set; }

    public Guid? RoleId { get; set; }

    public string? Comment { get; set; }

    public int? UserAttendanceModificationReasonId { get; set; }

    public long? LastModifyUserId { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? LastModifyDate { get; set; }

    public DateTime? DeletionDate { get; set; }
}
