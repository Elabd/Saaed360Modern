using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EsRepairPermissionStatus
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EsRepairPermission> EsRepairPermissions { get; set; } = new List<EsRepairPermission>();
}
