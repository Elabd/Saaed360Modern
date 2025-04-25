using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewSmsretry
{
    public long Id { get; set; }

    public string Smstext { get; set; } = null!;

    public string ReceiverMobileNumber { get; set; } = null!;

    public string SenderName { get; set; } = null!;

    public int NoRetry { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? LastRetryDate { get; set; }

    public bool IsArabic { get; set; }
}
