using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DetectLocationConfiguration
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public bool IsActive { get; set; }
}
