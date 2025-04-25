using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Arrest
{
    public long ActivityId { get; set; }

    public int? ArrestCategoryId { get; set; }

    public int? ArrestProbableCauseId { get; set; }

    public int? ArrestRightsReadResponseId { get; set; }

    public double? BloodAlcoholContent { get; set; }

    public bool? IntoxicantInvolvedIndicator { get; set; }

    public bool? ResistedIndicator { get; set; }

    public bool? RightsReadIndicator { get; set; }

    public string? RecordIdenification { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ArrestCategoryDim? ArrestCategory { get; set; }

    public virtual ArrestProbableCauseDim? ArrestProbableCause { get; set; }

    public virtual ArrestRightsReadResponseDim? ArrestRightsReadResponse { get; set; }
}
