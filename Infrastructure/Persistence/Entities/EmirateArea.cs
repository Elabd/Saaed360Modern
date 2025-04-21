using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmirateArea
{
    public int Id { get; set; }

    public long EmirateId { get; set; }

    public long AreaId { get; set; }

    public virtual Area Area { get; set; } = null!;

    public virtual EmirateDim Emirate { get; set; } = null!;
}
