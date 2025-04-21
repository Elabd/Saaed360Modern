using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Role
{
    public Guid ApplicationId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual ICollection<User1> Users { get; set; } = new List<User1>();
}
