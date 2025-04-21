using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRegistrationUserRequest
{
    public long RequestUserId { get; set; }

    public string? Tcn { get; set; }

    public string Username { get; set; } = null!;

    public string MobileNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime RequestDate { get; set; }

    public string? VerificationCode { get; set; }

    public DateTime? CustomerVerificationResponseTime { get; set; }

    public bool IsUserCreated { get; set; }

    public string EmailVerificationCode { get; set; } = null!;

    public DateTime? OtpexpirationDate { get; set; }

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();
}
