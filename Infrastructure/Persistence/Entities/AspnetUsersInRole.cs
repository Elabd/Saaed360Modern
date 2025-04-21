using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AspnetUsersInRole
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }

    public string? UserRoles { get; set; }

    public long Id { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual AspnetRole Role { get; set; } = null!;

    public virtual AspnetUser User { get; set; } = null!;
}
