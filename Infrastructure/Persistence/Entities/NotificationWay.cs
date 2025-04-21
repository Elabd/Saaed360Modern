using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class NotificationWay
{
    /// <summary>
    /// 1- for mail and 2- for SMS 
    /// </summary>
    public int NotificationWayId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<NotificationTypeRole> NotificationTypeRoles { get; set; } = new List<NotificationTypeRole>();
}
