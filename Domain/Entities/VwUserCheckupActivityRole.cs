using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwUserCheckupActivityRole
{
    public long ActivityId { get; set; }

    public long? PersonId { get; set; }

    public string? RoleCategory { get; set; }
}
