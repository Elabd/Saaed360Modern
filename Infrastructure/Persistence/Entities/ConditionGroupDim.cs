using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConditionGroupDim
{
    public int ConditionGroupId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Condition> Conditions { get; set; } = new List<Condition>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
