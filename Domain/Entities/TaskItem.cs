using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TaskItem
{
    public long Id { get; set; }

    public long? TaskId { get; set; }

    public long? ItemId { get; set; }

    public virtual Item? Item { get; set; }

    public virtual Task? Task { get; set; }
}
