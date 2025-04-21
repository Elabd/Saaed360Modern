using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

public partial class aspnet_Role
{
    public Guid ApplicationId { get; set; }

    public Guid RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string LoweredRoleName { get; set; } = null!;

    public string? Description { get; set; }

    public bool? IsSuperAdmin { get; set; }

    public Guid? CreatedBy { get; set; }

    public DateTime? CreationTime { get; set; }

    public long? DefaultPageId { get; set; }

    public Guid? ParentRoleId { get; set; }

    public bool? IsDeleted { get; set; }

    public long Id { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public virtual aspnet_User? CreatedByNavigation { get; set; }

    public virtual ICollection<aspnet_Role> InverseParentRole { get; set; } = new List<aspnet_Role>();

    public virtual aspnet_Role? ParentRole { get; set; }

    public virtual ICollection<aspnet_UsersInRole> aspnet_UsersInRoles { get; set; } = new List<aspnet_UsersInRole>();
}
