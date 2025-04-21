using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Warrant
{
    public long ActivityId { get; set; }

    public int? WarrantAppearanceBailForfeitId { get; set; }

    public int? WarrantExtraditionLimitationId { get; set; }

    public int? WarrantFurtherProcessingId { get; set; }

    public int? WarrantLevelId { get; set; }

    public int? WarrantCategoryId { get; set; }

    public int? WarrantProbableCauseId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual WarrantAppearanceBailForfeitDim? WarrantAppearanceBailForfeit { get; set; }

    public virtual WarrantCategoryDim? WarrantCategory { get; set; }

    public virtual WarrantExtraditionLimitationDim? WarrantExtraditionLimitation { get; set; }

    public virtual WarrantFurtherProcessingDim? WarrantFurtherProcessing { get; set; }

    public virtual WarrantLevelDim? WarrantLevel { get; set; }

    public virtual WarrantProbableCauseDim? WarrantProbableCause { get; set; }
}
