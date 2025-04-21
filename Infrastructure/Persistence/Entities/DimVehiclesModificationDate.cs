using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DimVehiclesModificationDate
{
    public int Key { get; set; }

    public DateTime? Value { get; set; }
}
