using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtViewReportDamagedProperty
{
    public int ReportId { get; set; }

    public int DamagedPropertyId { get; set; }

    public long? OrganizationId { get; set; }

    public long? ItemId { get; set; }

    public int? ImpactTypeId { get; set; }

    public int? ImpactLevelId { get; set; }

    public string? Note { get; set; }

    public int? PropertyTypeId { get; set; }

    public bool? IsPublicProperty { get; set; }
}
