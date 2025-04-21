using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CollisionTypeDim
{
    public long CollisionTypeId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();
}
