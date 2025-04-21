using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationRole
{
    public long Id { get; set; }

    public long? OrganizationId { get; set; }

    public Guid? RoleId { get; set; }

    public virtual Organization? Organization { get; set; }

    public virtual AspnetRole? Role { get; set; }
}
