using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileForgetPasswordRequest
{
    public long RequestId { get; set; }

    public long UserId { get; set; }

    public DateTime RequestDate { get; set; }

    public string? VerificationCode { get; set; }

    public DateTime? CustomerVerificationResponseTime { get; set; }

    public int RetryCount { get; set; }

    public DateTime CreatedAt { get; set; }
}
