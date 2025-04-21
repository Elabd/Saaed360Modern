using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportDamagePartslog
{
    public long Id { get; set; }

    public long ElectronicInspectionReportId { get; set; }

    public int DamagePartId { get; set; }

    public string? DamagePartName { get; set; }

    public long? StatusId { get; set; }

    public string? StatusName { get; set; }

    public long? ActionUserId { get; set; }

    public string? ActionUserName { get; set; }

    public DateTime? ActionDateTime { get; set; }

    public string? SentGroup { get; set; }

    public string? Comment { get; set; }

    public string? UserName { get; set; }

    public virtual DamagePartsDim DamagePart { get; set; } = null!;

    public virtual ElectronicInspectionReport ElectronicInspectionReport { get; set; } = null!;
}
