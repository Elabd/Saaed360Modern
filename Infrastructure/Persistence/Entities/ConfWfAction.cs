using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ConfWfAction
{
    public long ActionId { get; set; }

    public string? ActionName { get; set; }

    public virtual ICollection<ConfWfLevel> ConfWfLevels { get; set; } = new List<ConfWfLevel>();
}
