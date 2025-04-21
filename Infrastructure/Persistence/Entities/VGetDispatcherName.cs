using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VGetDispatcherName
{
    public long ActivityId { get; set; }

    public string DispatcherName { get; set; } = null!;
}
