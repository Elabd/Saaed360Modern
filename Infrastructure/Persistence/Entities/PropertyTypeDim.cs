using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PropertyTypeDim
{
    public int PropertyTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<DamagedProperty> DamagedProperties { get; set; } = new List<DamagedProperty>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
