using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Citation
{
    public long ActivityId { get; set; }

    public int? CitationDismissalConditionId { get; set; }

    public int? CitationStatusId { get; set; }

    public double? FineAmount { get; set; }

    public DateTime? DismissalDateTime { get; set; }

    public DateTime? CitationDateTime { get; set; }

    public string? RadarNumber { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CitationDismissalConditionDim? CitationDismissalCondition { get; set; }

    public virtual CitationStatusDim? CitationStatus { get; set; }
}
