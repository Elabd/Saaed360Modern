using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class NotificationMessageLogDetail
{
    public long NotificationMessageLogDetailsId { get; set; }

    public long NotificationMessageLogId { get; set; }

    public string Smstext { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public int RetryPeriodSecs { get; set; }

    public bool IsSmssentTry { get; set; }

    public DateTime? SmssentTryDate { get; set; }

    public virtual NotificationMessageLog NotificationMessageLog { get; set; } = null!;
}
