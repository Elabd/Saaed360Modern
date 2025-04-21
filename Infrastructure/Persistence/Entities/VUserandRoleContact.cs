using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VUserandRoleContact
{
    public string? Email { get; set; }

    public string ContactInformation { get; set; } = null!;

    public Guid RoleId { get; set; }

    public Guid UserId { get; set; }

    public long PersonId { get; set; }

    public long AreaId { get; set; }
}
