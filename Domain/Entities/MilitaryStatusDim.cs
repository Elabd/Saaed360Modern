using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MilitaryStatusDim
{
    public int MilitaryStatusId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonMilitarySummary> PersonMilitarySummaries { get; set; } = new List<PersonMilitarySummary>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
