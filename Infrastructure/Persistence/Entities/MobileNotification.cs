using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileNotification
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public long? NotifyingRecordId { get; set; }

    public string? MobileNotificationTypeId { get; set; }

    public bool? IsNotified { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? NotificationDateTime { get; set; }

    public long? RequestNumber { get; set; }

    public string? DeviceCode { get; set; }

    public int? MobileRequestStatusId { get; set; }

    public string? StatusTxt { get; set; }

    public virtual MobileRequest? RequestNumberNavigation { get; set; }
}
