using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ItemStatusDim
{
    public int ItemStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<Item> Items { get; set; } = new List<Item>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
