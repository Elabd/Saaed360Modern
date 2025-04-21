using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Bail
{
    public long ActivityId { get; set; }

    public int? BailRequirementId { get; set; }

    public int? BailConditionId { get; set; }

    public DateTime? BailHearingDate { get; set; }

    public DateTime? BailPostedDate { get; set; }

    public DateTime? BailRevokedDate { get; set; }

    public double? BailSetAmount { get; set; }

    public double? BailPostedAmount { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual BailConditionDim? BailCondition { get; set; }

    public virtual BailRequirementDim? BailRequirement { get; set; }
}
