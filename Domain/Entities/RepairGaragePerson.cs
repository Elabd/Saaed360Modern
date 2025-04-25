using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RepairGaragePerson
{
    public long PersonId { get; set; }

    public int RepairGarageId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RepairGarage RepairGarage { get; set; } = null!;
}
