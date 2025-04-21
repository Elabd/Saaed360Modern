using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArcproActionLogTypeDim
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<ArcproActionLog> ArcproActionLogs { get; set; } = new List<ArcproActionLog>();
}
