using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AssignmentPushRetry
{
    public long Id { get; set; }

    public long NotificationId { get; set; }

    public long PatrolId { get; set; }

    public long IncidentId { get; set; }

    public string TokenId { get; set; } = null!;

    public DateTime CreationTime { get; set; }

    public bool IsConfirmed { get; set; }

    public int RetryCount { get; set; }

    public DateTime? LastRetryTime { get; set; }

    public DateTime? ConfirmedTime { get; set; }

    public string? IncidentGeneratedNumber { get; set; }
}
