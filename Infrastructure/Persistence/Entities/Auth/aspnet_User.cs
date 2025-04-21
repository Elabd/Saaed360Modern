using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities.Auth;

public partial class aspnet_User
{
    public Guid ApplicationId { get; set; }

    public Guid UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string LoweredUserName { get; set; } = null!;

    public string? MobileAlias { get; set; }

    public bool IsAnonymous { get; set; }

    public DateTime LastActivityDate { get; set; }

    public long Id { get; set; }

    public DateTime? CreationTime { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public bool? isFromActiveDirectory { get; set; }

    public virtual ICollection<PersonAspnetUser> PersonAspnetUsers { get; set; } = new List<PersonAspnetUser>();

    public virtual aspnet_Membership? aspnet_Membership { get; set; }

    public virtual ICollection<aspnet_Role> aspnet_Roles { get; set; } = new List<aspnet_Role>();

    public virtual ICollection<aspnet_UsersInRole> aspnet_UsersInRoles { get; set; } = new List<aspnet_UsersInRole>();
}
