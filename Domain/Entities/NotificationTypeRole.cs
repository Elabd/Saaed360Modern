using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NotificationTypeRole
{
    public long NotificationTypeRoleId { get; set; }

    public int? NotificationWayId { get; set; }

    public long? StateNotificationRoleId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual NotificationWay? NotificationWay { get; set; }
}
