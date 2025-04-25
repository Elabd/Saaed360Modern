using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileVerificationService
{
    public long Id { get; set; }

    public string MobileNumber { get; set; } = null!;

    public string GeneratedVerificationCode { get; set; } = null!;

    public DateTime CreateTime { get; set; }

    public bool IsLastVerificationCode { get; set; }
}

