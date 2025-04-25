using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AreaSupportNumber
{
    public long AreaSupportNumberId { get; set; }

    public long AreaId { get; set; }

    public string SupportNumber { get; set; } = null!;
}
