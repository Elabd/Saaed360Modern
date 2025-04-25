using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Drug
{
    public long ItemId { get; set; }

    public int? DrugCategoryId { get; set; }

    public int? DrugSubstanceFormId { get; set; }

    public int? DrugContainerId { get; set; }

    public int? DrugCompositionId { get; set; }

    public int? DrugFoundId { get; set; }

    public double? QuantityMeasure { get; set; }

    public virtual DrugCategoryDim? DrugCategory { get; set; }

    public virtual DrugCompositionDim? DrugComposition { get; set; }

    public virtual DrugContainerDim? DrugContainer { get; set; }

    public virtual DrugFoundDim? DrugFound { get; set; }

    public virtual DrugSubstanceFormDim? DrugSubstanceForm { get; set; }

    public virtual Item Item { get; set; } = null!;
}
