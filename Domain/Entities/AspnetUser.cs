using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AspnetUser
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

    public bool? IsFromActiveDirectory { get; set; }

    public virtual AspnetApplication Application { get; set; } = null!;

    public virtual AspnetMembership? AspnetMembership { get; set; }

    public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = new List<AspnetPersonalizationPerUser>();

    public virtual AspnetProfile? AspnetProfile { get; set; }

    public virtual ICollection<AspnetRole> AspnetRoles { get; set; } = new List<AspnetRole>();

    public virtual ICollection<AspnetUsersInRole> AspnetUsersInRoles { get; set; } = new List<AspnetUsersInRole>();

    public virtual ICollection<InternalUserPasswordChangeHistory> InternalUserPasswordChangeHistories { get; set; } = new List<InternalUserPasswordChangeHistory>();

    public virtual ICollection<PersonAspnetUser> PersonAspnetUsers { get; set; } = new List<PersonAspnetUser>();

    public virtual ICollection<UserCodesForgetPassword> UserCodesForgetPasswords { get; set; } = new List<UserCodesForgetPassword>();
}
