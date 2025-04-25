using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileMessage
{
    public long MobileMessagesId { get; set; }

    public string? MessageText { get; set; }

    public int? MessageDirection { get; set; }

    public bool? IsNotified { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? MessageDateTime { get; set; }

    public long? RequestNumber { get; set; }

    public string? DeviceCode { get; set; }

    public virtual MobileRequest? RequestNumberNavigation { get; set; }
}
