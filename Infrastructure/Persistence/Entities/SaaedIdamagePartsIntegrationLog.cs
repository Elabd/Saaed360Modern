using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedIdamagePartsIntegrationLog
{
    public Guid DamagePartIntegrationId { get; set; }

    public DateTime CreationDate { get; set; }

    public int ReportId { get; set; }

    public int DamagePartId { get; set; }

    public int? VehicleDataId { get; set; }

    public virtual DamagePartsDim DamagePart { get; set; } = null!;

    public virtual Report Report { get; set; } = null!;

    public virtual VehicleDatum? VehicleData { get; set; }
}
