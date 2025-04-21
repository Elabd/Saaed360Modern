using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportAnswer
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public long ElectronicInspectionQuestionId { get; set; }

    public long ElectronicInspectionAnswerId { get; set; }

    public bool IsDamage { get; set; }

    public int LastElectronicInspectionDamageStatusId { get; set; }

    public long? LastModifyUserId { get; set; }

    public DateTime LastModifyDateTime { get; set; }

    public string? DamageComment { get; set; }

    public string? MaintenanceComment { get; set; }

    public virtual ElectronicInspectionAnswer ElectronicInspectionAnswer { get; set; } = null!;

    public virtual ElectronicInspectionQuestion ElectronicInspectionQuestion { get; set; } = null!;

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;

    public virtual Person? LastModifyUser { get; set; }
}
