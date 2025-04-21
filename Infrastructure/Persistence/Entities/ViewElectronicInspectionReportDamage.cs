using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewElectronicInspectionReportDamage
{
    public long ReportId { get; set; }

    public long ReportDamageId { get; set; }

    public int DamagePartId { get; set; }

    public string DamagePartName { get; set; } = null!;

    public Guid? Fmscode { get; set; }
}
