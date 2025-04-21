using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Victim
{
    public long PersonId { get; set; }

    public int VictimCategoryId { get; set; }

    public int VictimMeansOfAttackId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual VictimCategoryDim VictimCategory { get; set; } = null!;

    public virtual VictimMeansOfAttackDim VictimMeansOfAttack { get; set; } = null!;
}
