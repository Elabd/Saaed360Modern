using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsMobileVerification
{
    public Guid SessionId { get; set; }

    public string Mobile { get; set; } = null!;

    public string VerificationCode { get; set; } = null!;

    public bool IsVerified { get; set; }

    public int RetriesCount { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime? LastRetryDate { get; set; }
}
