using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EmirateDimToAreaMapping
{
    public int Id { get; set; }

    public int AreaIdForEmirate { get; set; }

    public int EmirateId { get; set; }
}
