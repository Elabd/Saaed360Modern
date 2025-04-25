using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Bond
{
    public long ActivityId { get; set; }

    public int? BondConditionId { get; set; }

    public int? BondTerminationCategoryId { get; set; }

    public int? BondPaymentId { get; set; }

    public double? BondAmount { get; set; }

    public DateTime? BondRevolkeDate { get; set; }

    public DateTime? BondTerminationDate { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual BondConditionDim? BondCondition { get; set; }

    public virtual BondPaymentDim? BondPayment { get; set; }

    public virtual BondTerminationCategoryDim? BondTerminationCategory { get; set; }
}
