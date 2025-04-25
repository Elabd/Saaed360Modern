using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VGetDispatcherName
{
    public long ActivityId { get; set; }

    public string DispatcherName { get; set; } = null!;
}
