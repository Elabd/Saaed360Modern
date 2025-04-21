using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

public partial class aspnet_UsersInRole
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }

    public string? UserRoles { get; set; }

    public long Id { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual aspnet_Role Role { get; set; } = null!;

    public virtual aspnet_User User { get; set; } = null!;
}
