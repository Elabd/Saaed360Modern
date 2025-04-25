using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DetectLocationConfiguration
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public bool IsActive { get; set; }
}
