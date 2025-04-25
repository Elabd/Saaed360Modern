using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StateNotificationRoleRelationTypeDim
{
    public int RelationTypeId { get; set; }

    public string? Code { get; set; }

    public string Desc { get; set; } = null!;

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<StateNotificationRole> StateNotificationRoles { get; set; } = new List<StateNotificationRole>();
}
