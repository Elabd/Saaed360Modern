using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ClientApplication
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int UserTypeId { get; set; }

    public virtual ICollection<ChangePasswordSession> ChangePasswordSessions { get; set; } = new List<ChangePasswordSession>();

    public virtual UserType UserType { get; set; } = null!;
}
