using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class BondConditionDim
{
    public int BondConditionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Bond> Bonds { get; set; } = new List<Bond>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
