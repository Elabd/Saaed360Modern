using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EsRepairPermissionDamagedPart
{
    public long RepairPermissionId { get; set; }

    public int PartId { get; set; }

    public int? SeverityId { get; set; }

    public virtual DamagePartsDim Part { get; set; } = null!;

    public virtual EsRepairPermission RepairPermission { get; set; } = null!;

    public virtual DamagedPartSeverityDim? Severity { get; set; }
}
