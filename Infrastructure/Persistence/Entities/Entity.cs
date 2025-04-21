using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Entity
{
    public int EntityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Status> Statuses { get; set; } = new List<Status>();
}

