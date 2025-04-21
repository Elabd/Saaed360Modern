using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DamagePartsDim
{
    public int DamagePartId { get; set; }

    public string DamagePart { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public Guid? Fmscode { get; set; }

    public virtual ICollection<ElectronicInspectionReportDamagePart> ElectronicInspectionReportDamageParts { get; set; } = new List<ElectronicInspectionReportDamagePart>();

    public virtual ICollection<ElectronicInspectionReportDamagePartslog> ElectronicInspectionReportDamagePartslogs { get; set; } = new List<ElectronicInspectionReportDamagePartslog>();

    public virtual ICollection<EsRepairPermissionDamagedPart> EsRepairPermissionDamagedParts { get; set; } = new List<EsRepairPermissionDamagedPart>();

    public virtual ICollection<SaaedIdamagePartsIntegrationLog> SaaedIdamagePartsIntegrationLogs { get; set; } = new List<SaaedIdamagePartsIntegrationLog>();

    public virtual ICollection<VehicleDamagePart> VehicleDamageParts { get; set; } = new List<VehicleDamagePart>();
}
