using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemConditionDim
{
    public int ItemConditionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
