using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Condition
{
    public long ActivityId { get; set; }

    public int ConditionGroupId { get; set; }

    public int ConditionViolationId { get; set; }

    public bool ConditionMandatoryIndicator { get; set; }

    public bool ConditionViolatedIndicator { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ConditionGroupDim ConditionGroup { get; set; } = null!;

    public virtual ConditionViolationDim ConditionViolation { get; set; } = null!;
}
