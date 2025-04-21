using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ExternalUserPasswordChangeHistory
{
    public long Id { get; set; }

    public long UserId { get; set; }

    public string Salt { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public bool IsInitiate { get; set; }

    public virtual MobileUser User { get; set; } = null!;
}
