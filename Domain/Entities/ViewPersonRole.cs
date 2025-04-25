using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewPersonRole
{
    public long PersonId { get; set; }

    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleCategory { get; set; }

    public string? RoleCategoryCode { get; set; }
}
