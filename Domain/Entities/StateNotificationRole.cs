using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StateNotificationRole
{
    public long StateNotificationRoleId { get; set; }

    public long? StateId { get; set; }

    public Guid? RoleId { get; set; }

    public string? Desc { get; set; }

    public int? RelationTypeId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual StateNotificationRoleRelationTypeDim? RelationType { get; set; }

    public virtual AspnetRole? Role { get; set; }

    public virtual State? State { get; set; }
}
