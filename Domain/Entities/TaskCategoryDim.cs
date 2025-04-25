using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TaskCategoryDim
{
    public long Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public DateTime? VersionDateTime { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
