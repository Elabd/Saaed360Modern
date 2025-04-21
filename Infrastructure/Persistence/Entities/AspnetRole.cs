using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class AspnetRole
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

    public virtual AspnetApplication Application { get; set; } = null!;

    public virtual ICollection<AspnetUsersInRole> AspnetUsersInRoles { get; set; } = new List<AspnetUsersInRole>();

    public virtual AspnetUser? CreatedByNavigation { get; set; }

    public virtual ApplicationPage? DefaultPage { get; set; }

    public virtual ICollection<AspnetRole> InverseParentRole { get; set; } = new List<AspnetRole>();

    public virtual ICollection<OrganizationRole> OrganizationRoles { get; set; } = new List<OrganizationRole>();

    public virtual ICollection<PageActionRole> PageActionRoles { get; set; } = new List<PageActionRole>();

    public virtual ICollection<PageRole> PageRoles { get; set; } = new List<PageRole>();

    public virtual AspnetRole? ParentRole { get; set; }

    public virtual ICollection<StateNotificationRole> StateNotificationRoles { get; set; } = new List<StateNotificationRole>();

    public virtual ICollection<State> States { get; set; } = new List<State>();

    public virtual ICollection<ViolationsStepsRole> ViolationsStepsRoles { get; set; } = new List<ViolationsStepsRole>();
}
