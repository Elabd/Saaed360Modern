using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DisciplinaryAction
{
    public long ActivityId { get; set; }

    public decimal? DisciplinaryActionFee { get; set; }

    public virtual Activity Activity { get; set; } = null!;
}
