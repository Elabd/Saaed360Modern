using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMdtusersInRolesSyncHelper
{
    public Guid UserId { get; set; }

    public Guid RoleId { get; set; }

    public string? UserRoles { get; set; }

    public long Id { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModifiedDate { get; set; }
}
