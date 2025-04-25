using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class JurorDismissedReasonDim
{
    public int JurorDismissedReasonId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Juror> Jurors { get; set; } = new List<Juror>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
