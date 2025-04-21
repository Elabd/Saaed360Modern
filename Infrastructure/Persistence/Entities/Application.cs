using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Application
{
    public string ApplicationName { get; set; } = null!;

    public Guid ApplicationId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Membership> Memberships { get; set; } = new List<Membership>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();

    public virtual ICollection<User1> User1s { get; set; } = new List<User1>();
}
