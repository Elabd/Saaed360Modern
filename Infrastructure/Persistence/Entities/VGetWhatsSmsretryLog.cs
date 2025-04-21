using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VGetWhatsSmsretryLog
{
    public long NotificationMessageLogDetailsId { get; set; }

    public long MessageLogId { get; set; }

    public string ReceiverMobileNumber { get; set; } = null!;

    public string? ReferenceRequestId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Smstext { get; set; } = null!;

    public string Lang { get; set; } = null!;

    public int RetryPeriodSecs { get; set; }
}
