using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class InternalUserPasswordChangeHistory
{
    public long Id { get; set; }

    public Guid UserId { get; set; }

    public string Salt { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime ChangeDate { get; set; }

    public bool IsInitiate { get; set; }

    public virtual AspnetUser User { get; set; } = null!;
}
