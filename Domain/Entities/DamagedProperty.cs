using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DamagedProperty
{
    public int DamagedPropertyId { get; set; }

    public long? OrganizationId { get; set; }

    public long? ItemId { get; set; }

    public int? ImpactTypeId { get; set; }

    public int? ImpactLevelId { get; set; }

    public string? Note { get; set; }

    public int? PropertyTypeId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsPublicProperty { get; set; }

    public string? OrganizationOthersDescription { get; set; }

    public string? DamagedObjectOthersDescription { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ImpactLevelDim? ImpactLevel { get; set; }

    public virtual ImpactTypeDim? ImpactType { get; set; }

    public virtual Item? Item { get; set; }

    public virtual PropertyTypeDim? PropertyType { get; set; }

    public virtual ICollection<ReportDamagedProperty> ReportDamagedProperties { get; set; } = new List<ReportDamagedProperty>();
}
