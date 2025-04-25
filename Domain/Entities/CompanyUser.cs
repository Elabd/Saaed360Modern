using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CompanyUser
{
    public long CompanyUserId { get; set; }

    public long? CompanyId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? SaltPassword { get; set; }

    public bool? IsActive { get; set; }

    public string? ActivationCode { get; set; }

    public string? ResetPasswordCode { get; set; }

    public virtual Company? Company { get; set; }
}
