using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AutoDispatchConfiguration
{
    public long Id { get; set; }

    public long AreaId { get; set; }

    public bool IsActive { get; set; }
}
