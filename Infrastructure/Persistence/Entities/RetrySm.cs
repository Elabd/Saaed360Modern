using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RetrySm
{
    public long Id { get; set; }

    public string Smstext { get; set; } = null!;

    public string ReceiverMobileNumber { get; set; } = null!;

    public string SenderName { get; set; } = null!;

    public bool IsSent { get; set; }

    public int NoRetry { get; set; }

    public bool IsArabic { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime? LastRetryDate { get; set; }

    public DateTime? SentDate { get; set; }
}
