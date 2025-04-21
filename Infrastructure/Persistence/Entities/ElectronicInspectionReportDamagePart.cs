using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportDamagePart
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public int DamagePartId { get; set; }

    public long? StatusId { get; set; }

    public string? MaintenanceComment { get; set; }

    public long? LastModifyUserId { get; set; }

    public virtual DamagePartsDim DamagePart { get; set; } = null!;

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;

    public virtual Person? LastModifyUser { get; set; }
}
